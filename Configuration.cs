namespace Blog;

public static class Configuration
{
    public static string JwtKey { get; set; } = "YjViYmNlM2MtM2M2OC00ZjZlLTg0Y2MtNGUyOTUyNjM3ZDEw";

    public static string ApiKeyName = "api_key";

    public static string ApiKey = "curso_api_8Rjj0C87rU2s/i9bHdQZog==";

    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
