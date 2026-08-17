using FundooNotesApp.Models;

namespace FundooNotesApp.Business
{
    public interface IUserService
    {
        ResponseDTO<User> Register(RegisterDTO registerDTO);
        ResponseDTO<string> Login(LoginDTO loginDTO);
        ResponseDTO<string> ForgotPassword(ForgotPasswordDTO forgotPasswordDTO);
        ResponseDTO<bool> ResetPassword(ResetPasswordDTO resetPasswordDTO);
    }
}