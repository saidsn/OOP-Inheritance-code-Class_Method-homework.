using System;

namespace Class_Method_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factorial
            Homework result = new Homework();
            int n = 5;
            int fact = Homework.Factorial(n);
            Console.WriteLine(fact);
            #endregion

            #region Mail or password
            MailHomework Email = new MailHomework();
            string mail = "Cavid@code.edu.az";
            int password = 12345;

            if (MailHomework.CheckMail(mail, password))
            {
                Console.WriteLine("Giris olundu");
            }
            else
            {
                Console.WriteLine("Mail ve ya password sehvdir");
            }
            #endregion


        }
    }
    #region Factorial
    public class Homework
    {
        public static int Factorial(int n)
        {

            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
    #endregion

    #region Mail or password
    public class MailHomework
    {
        public static bool CheckMail(string mail, int password)
        {

            if (mail == "Cavid@code.edu.az" && password == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
    #endregion



}
