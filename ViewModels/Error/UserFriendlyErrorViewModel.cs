using FirstAspDotnetApp.Exceptions;

namespace FirstAspDotnetApp.ViewModels.Error
{
    public class UserFriendlyErrorViewModel
    {
        public string Type { get; set; }

        public string Message { get; set; }
        public UserFriendlyErrorViewModel() { }

        public UserFriendlyErrorViewModel(UserFriendlyException ufe)
        {
            Type = ufe.Type!;
            Message = ufe.Message;
        }
    }
}
