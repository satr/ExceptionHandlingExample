namespace Common.Services
{
    public class NullHumanInteractionService : IHumanInteractionService
    {
        public void ShowError(string message)
        {
        }

        public void ShowWarning(string message)
        {
        }

        public void ShowInfo(string message)
        {
        }
    }
}