using FundooNotesApp.Models;
using FundooNotesApp.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FundooNotesApp.Business
{
    public class UserServiceImpl : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        public UserServiceImpl(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }
        public ResponseDTO<User> Register(RegisterDTO registerDTO)
        {
            var existingUser = _userRepository.GetUserByEmail(registerDTO.EmailAddress);
            if (existingUser != null)
            {
                return new ResponseDTO<User> { Success = false, Message = "Email Address already exists." };
            }
            string password = BCrypt.Net.BCrypt.HashPassword(registerDTO.Password);

            var user = new User
            {
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
                EmailAddress = registerDTO.EmailAddress,
                Password = password
            };
            var createdUser = _userRepository.CreateUser(user);
            return new ResponseDTO<User> { Success = true, Message = "Registration Successfull", Data = createdUser };
        }
        public ResponseDTO<string> Login(LoginDTO loginDTO)
        {
            var user = _userRepository.GetUserByEmail(loginDTO.EmailAddress);
            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDTO.Password, user.Password))
            {
                return new ResponseDTO<string> { Success = false, Message = "Invalid Credentials." };
            }
            var token = GenerateJwtToken(user);
            return new ResponseDTO<string> { Success = true, Message = "Login Successfully.", Data = token};
        }
        public ResponseDTO<string> ForgotPassword(ForgotPasswordDTO forgotPasswordDTO)
        {
            var user = _userRepository.GetUserByEmail(forgotPasswordDTO.EmailAddress);
            if (user == null)
            {
                return new ResponseDTO<string> { Success = false, Message = "User does not exist. " };
            }
            var resetToken = GenerateJwtToken(user);
            return new ResponseDTO<string> { Success = true, Message = "Reset token generated successfully.", Data = resetToken };
        }
        public ResponseDTO<bool> ResetPassword(ResetPasswordDTO resetPasswordDTO)
        {
            string newPassword = BCrypt.Net.BCrypt.HashPassword(resetPasswordDTO.NewPassword);
            bool isUpdated = _userRepository.UpdatePassword(resetPasswordDTO.EmailAddress, newPassword);
            if (isUpdated)
            {
                return new ResponseDTO<bool> { Success = true, Message = "Password Updated Successfully .", Data = true };
            }
            return new ResponseDTO<bool> { Success = false, Message = "Password Reset failed .", Data = false };
        }
        private string GenerateJwtToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Email, user.EmailAddress),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}")
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(2),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}