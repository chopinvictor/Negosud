namespace NegosudWpf.Models;
public class LoginUser
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public string twoFactorCode { get; } = "string";
    public string twoFactorRecoveryCode { get; } = "string";
}