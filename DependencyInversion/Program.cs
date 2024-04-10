namespace DotNetOOPMasterClass.DependencyInversion
{
    public class Program
    {
        public static void Main()
        {
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            NotificationServerClient emailServerClient = new(emailService);
            NotificationServerClient smsServerClient = new(smsService);
            NotificationServerClient pushServerClient = new(pushService);

            Console.WriteLine(emailServerClient.SendNotification("Hello via email"));
            Console.WriteLine(smsServerClient.SendNotification("Hello via sms"));
            Console.WriteLine(pushServerClient.SendNotification("Hello via push notification"));
        }
    }

    public interface INotificationService
    {
        string SendNotification(string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public string SendNotification(string message)
        {
            return $"Sending email notification: {message}";
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public string SendNotification(string message)
        {
            return $"Sending SMS notification: {message}";
        }
    }

    public class PushNotificationService : INotificationService
    {
        public string SendNotification(string message)
        {
            return $"Sending push notification: {message}";
        }
    }

    public class NotificationServerClient(INotificationService notificationService)
    {
        private readonly INotificationService _notificationService = notificationService;

        public string SendNotification(string message)
        {
            return _notificationService.SendNotification(message);
        }
    }
}