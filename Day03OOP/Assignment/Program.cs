using System;
using System.Data;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    public interface IShape
    {
        decimal Area { get; }
        void DisplayShapeInfo();
        void DrawShape();
    }

    public interface ICircle : IShape
    {
        decimal Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        decimal Length { get; set; }
        decimal Width { get; set; }
    }

   
    class Circle : ICircle
    {
        public decimal Radius { get; set; }

        public decimal Area => CalculateAreaOfCircle();

        private decimal CalculateAreaOfCircle()
        {
            return (decimal)((double)Math.PI * (double)Radius * (double)Radius);
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius: {Radius} and area: {Area}");
        }

        public void DrawShape()
        {
            int radius = (int)Radius;
            double thickness = 0.4;
            char symbol = '*';

            double rIn = radius - thickness;
            double rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Rectangle : IRectangle
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }

        public decimal Area => CalculateAreaOfRectangle();

        private decimal CalculateAreaOfRectangle()
        {
            return Length * Width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with length: {Length}, width: {Width}, and area: {Area}");
        }

        public void DrawShape()
        {
            for (int i = 0; i < (int)Length; i++)
            {
                for (int j = 0; j < (int)Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }



    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private  string[] usernames = { "islam", "fawaz" };
        private  string[] clonedPasswords = { ClonePassword("islam123"), ClonePassword("fawaz123") };
        private  string[] roles = { "admin", "user" };

        public bool AuthenticateUser(string username, string password)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && VerifyPassword(password, clonedPasswords[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && roles[i] == role)
                {
                    return true;
                }
            }
            return false;
        }

        private static string ClonePassword(string password)
        {
            return password;
        }

        private bool VerifyPassword(string password, string clonedPassword)
        {
            return password == clonedPassword;
        }
    }


    interface INotificationService
    {
       void SendNotification(string recipient,string message);

    }

    class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Email to {recipient}: {message}");
        }
    }
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
        }
    }

    class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PART01
            //PART 01
            //1 b) To define a blueprint for a class
            //2 b) protected
            //3 b) No
            //4 b) Yes, interfaces can inherit from multiple interfaces
            //5  d) implements
            //6 a) Yes
            //7 b) No, all members are implicitly public
            //8 a) To hide the interface members from outside access
            //9 b) No, interfaces cannot have constructors
            //10 c) By separating interface names with commas

            #endregion


            //PART02

            #region Question1

            // Question 01:
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo
            //.Create two interfaces, ICircle and IRectangle, that inherit from IShape.
            //Implement these interfaces in classes Circle and Rectangle.
            //Test your implementation by creating instances of both classes and
            //displaying their shape information.





            //ICircle circle = new Circle();
            //circle.Radius = 3.0m;
            //circle.DisplayShapeInfo();
            //circle.DrawShape();

            //IRectangle rectangle = new Rectangle();
            //rectangle.Length = 10.0m;
            //rectangle.Width = 30.0m;
            //rectangle.DisplayShapeInfo();
            //rectangle.DrawShape(); 
            #endregion


            #region Question2
            //Question 02:
            // In this example, we start by defining the IAuthenticationService interface with two methods:
            // AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this
            // interface and provides the specific implementation for these methods.
            // Inthe BasicAuthenticationService class, the AuthenticateUser method
            // compares the provided username and password with the stored credentials.
            // It returns true if the user is authenticated and false otherwise.The AuthorizeUser method
            // checks if the user with the given username has the specified role.It returns true
            // if the user is authorized and false otherwise.In the Main method,
            // we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            //This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

            
            //    IAuthenticationService authService = new BasicAuthenticationService();

                //string username = "fawaz";
                //string password = "fawaz123"; 
                //string role = "user";

                //bool isAuthenticated = authService.AuthenticateUser(username, password);
                //bool isAuthorized = authService.AuthorizeUser(username, role);

                //Console.WriteLine($"User authenticated: {isAuthenticated}");
                //Console.WriteLine($"User authorized: {isAuthorized}");
            }

        #endregion

        #region Question3
        //Question3        we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
        //We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
        //In each implementation, we provide the logic to send notifications through the respective communication channel:
        //The EmailNotificationService class simulates sending an email by outputting a message to the console.
        //The SmsNotificationService class simulates sending an SMS by outputting a message to the console.

        
        //INotificationService emailService = new EmailNotificationService();
        //INotificationService smsService = new SmsNotificationService();
        //INotificationService pushService = new PushNotificationService(); 




    }
}
        #endregion

    