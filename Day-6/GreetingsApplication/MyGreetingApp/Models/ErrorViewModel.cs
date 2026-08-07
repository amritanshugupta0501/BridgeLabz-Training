namespace MyGreetingApp.Models;

// View model used to display error information to the user.
public class ErrorViewModel
{
    // Unique identifier for the current request.
    public string? RequestId { get; set; }

    // Indicates whether a request ID should be shown in the view.
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
