namespace FirstAspDotnetApp.Exceptions
{
    public static class ExceptionTypeEnum
    {
        public static readonly string Error = "danger";
        public static readonly string Warning = "warning";
    }


    public class UserFriendlyException : Exception
    {
        public string? Type { get; set; }
        public UserFriendlyException(string? message) : base(message)
        {
        }

        public UserFriendlyException(string? message, string? type) : base(message)
        {
            Type = type;
        }

    }
}
