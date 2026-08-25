namespace FundooNotesApp.Models
{
    public class ResetPasswordDTO
    {
        public string EmailAddress { get; set; }
        public string Token { get; set; }
        public string NewPassword { get; set; }
    }
}