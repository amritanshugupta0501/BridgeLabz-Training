using FundooNotesApp.Models;
using FundooNotesApp.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FundooNotesApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterDTO registerDTO)
        {
            var result = _userService.Register(registerDTO);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            var result = _userService.Login(loginDTO);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword([FromBody] ForgotPasswordDTO forgotPasswordDTO)
        {
            var result = _userService.ForgotPassword(forgotPasswordDTO);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost("reset-password")]
        public IActionResult ResetPassword([FromBody] ResetPasswordDTO resetPasswordDTO)
        {
            var result = _userService.ResetPassword(resetPasswordDTO);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [Authorize]
        [HttpGet("check")]
        public IActionResult CheckAuth()
        {
            return Ok(new { Success = true, Message = "Authentication successfull ! You are securely logged in." });
        }
    }
}