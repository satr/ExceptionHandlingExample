namespace Common.Services
{
    public interface IHumanInteractionService
    {
        void ShowError(string message);
        void ShowWarning(string message);
        void ShowInfo(string message);
    }
}