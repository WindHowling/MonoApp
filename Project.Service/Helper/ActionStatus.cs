
namespace Project.Service.Helper
{
    public class ActionStatus
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public static ActionStatus Success(string message = "") =>
            new ActionStatus { IsSuccess = true, Message = message };

        public static ActionStatus Failure(string message) =>
            new ActionStatus { IsSuccess = false, Message = message };
    }
}
