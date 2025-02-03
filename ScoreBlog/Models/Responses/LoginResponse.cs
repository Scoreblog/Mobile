namespace ScoreBlog;

public record LoginResponse(int StatusCode, List<Notification> Notifications, string Token)
{
    public bool IsSuccess => StatusCode == 200;
};