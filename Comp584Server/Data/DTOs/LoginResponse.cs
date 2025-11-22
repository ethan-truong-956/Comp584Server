namespace Comp584Server.Data.DTOs
{
    public class LoginResponse
    {
        public required bool Success { get; set; }
        public required string Message { get; set; } = string.Empty;
        public required string Token { get; set; } = string.Empty;
    }
}
