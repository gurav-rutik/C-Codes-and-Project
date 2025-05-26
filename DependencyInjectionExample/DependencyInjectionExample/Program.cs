namespace DependencyInjectionExample
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }

    public class UserService
    {
        private EmailService _emailService;

        public UserService()
        {
            _emailService = new EmailService(); // Directly creating the dependency
        }

        public void RegisterUser(string name)
        {
            Console.WriteLine($"User {name} registered successfully.");
            _emailService.SendEmail($"Welcome {name}!");
        }
    }

    class Program
    {
        static void Main()
        {
            UserService userService = new UserService();
            userService.RegisterUser("John Doe");
        }
    }
}
