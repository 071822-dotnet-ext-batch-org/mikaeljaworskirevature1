



using System;

namespace _6_FlowControl
{
    public class Program
    {
        public static string username { get; set; }
        public static string password { get; set; }

        static void Main(string[] args)
        {
        }

        /// <summary>
        /// This method gets a valid temperature between -40 asnd 135 inclusive from the user
        /// and returns the valid int. 
        /// </summary>
        /// <returns></returns>
        public static int GetValidTemperature()
        {
            int temp = 110;

            do
            {
                Console.WriteLine("the temperature is ");
                Console.ReadLine();

            } while(temp > -40 || temp < 135);

             return temp;
            //throw new NotImplementedException($"GetValidTemperature() has not been implemented.");
        }

        /// <summary>
        /// This method has one int parameter
        /// It prints outdoor activity advice and temperature opinion to the console 
        /// based on 20 degree increments starting at -20 and ending at 135 
        /// n < -20, Console.Write("hella cold");
        /// -20 <= n < 0, Console.Write("pretty cold");
        ///  0 <= n < 20, Console.Write("cold");
        /// 20 <= n < 40, Console.Write("thawed out");
        /// 40 <= n < 60, Console.Write("feels like Autumn");
        /// 60 <= n < 80, Console.Write("perfect outdoor workout temperature");
        /// 80 <= n < 90, Console.Write("niiice");
        /// 90 <= n < 100, Console.Write("hella hot");
        /// 100 <= n < 135, Console.Write("hottest");
        /// </summary>
        /// <param name="temp"></param>
        public static void GiveActivityAdvice(int temp)
        {
            switch(temp)
            {
                case < -20:
                System.Console.WriteLine("hello cold");
                break;

                case < 0:
                System.Console.WriteLine("pretty cold");
                break;

                case < 20: 
                System.Console.WriteLine("cold");
                break;

                case < 40:
                System.Console.WriteLine("thawed out");
                break;

                case < 60:
                System.Console.WriteLine("feels like autumn");
                break;

                case < 80:
                System.Console.WriteLine("perfect outdoor workout temperature");
                break;

                case < 90: 
                System.Console.WriteLine("niiice");
                break;

                case < 100: 
                System.Console.WriteLine("hella hot");
                break;

                case < 135:
                System.Console.WriteLine("hottest");
                break;

                default:
                System.Console.WriteLine("This is the switched Statement default.");
                break;

            }
            //throw new NotImplementedException($"GiveActivityAdvice() has not been implemented.");
        }

        /// <summary>
        /// This method gets a username and password from the user
        /// and stores that data in the global variables of the 
        /// names in the method.
        /// </summary>
        public static void Register()
        {
            
            Console.WriteLine("Please enter user ID.");
            username = Console.ReadLine();
            
            Console.WriteLine("Please enter a password");
            password = Console.ReadLine();
            Console.WriteLine($"{username} is now registered.");

            //throw new NotImplementedException($"Register() has not been implemented.");
        }

        /// <summary>
        /// This method gets username and password from the user and
        /// compares them with the username and password names provided in Register().
        /// If the password and username match, the method returns true. 
        /// If they do not match, the user is reprompted for the username and password
        /// until the exact matches are inputted.
        /// </summary>
        /// <returns></returns>
        public static bool Login()
        {
            string userInput;
            string userPassword;

            do
            {
             Console.WriteLine("Please enter user ID.");
             userInput = Console.ReadLine();

             Console.WriteLine("Please enter user password.");
             userPassword = Console.ReadLine();

            } 
            while (!Equals(userInput, username) || !Equals(userPassword, password));
            return true;
            //throw new NotImplementedException($"Login() has not been implemented.");
        }

        /// <summary>
        /// This method has one int parameter.
        /// It checks if the int is <=42, Console.WriteLine($"{temp} is too cold!");
        /// between 43 and 78 inclusive, Console.WriteLine($"{temp} is an ok temperature");
        /// or > 78, Console.WriteLine($"{temp} is too hot!");
        /// For each temperature range, a different advice is given. 
        /// </summary>
        /// <param name="temp"></param>
        public static void GetTemperatureTernary(int temp)
        {
            string result = temp <= 42 ? $"{temp} is too cold!" : temp >= 43 && temp <= 78 ? $"{temp} is an ok temperature" : temp > 78 ? $"{temp} is too hot!" : "This is the default catch-all";
            System.Console.WriteLine(result);
            //throw new NotImplementedException($"GetTemperatureTernary() has not been implemented.");
        }
    }//EoP
}//EoN
