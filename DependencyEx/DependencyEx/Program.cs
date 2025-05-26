namespace DependencyEx
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            UserService userService = new UserService();
            userService.RegisterUser("Rutik Gurav");

            Console.ReadKey();
        }
    }
    class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Sending email : "+message);
        }
    }

    class UserService
    {
        private EmailService _emailService;

        public UserService()
        {
            _emailService = new EmailService();
            _emailService.SendEmail("Hello Rutik!!");
        }

        public void RegisterUser(string name)
        {
            Console.WriteLine("welcome "+name);
        }
    }
}
