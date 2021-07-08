using System;
using System.Linq;
using _3.Telephony.Contracts;
using _3.Telephony.Models;

namespace _3.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] foneNums = Console.ReadLine().Split();
            string[] URLs = Console.ReadLine().Split();

            StationaryPhone currPhone = new StationaryPhone();
            Smartphone currSmartPhone = new Smartphone();

            foreach (var num in foneNums)
            {


                if (num.Length == 7)
                {
                    try
                    {
                        currPhone.Call(num);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        currSmartPhone.Call(num);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

            }


            foreach (var URL in URLs)
            {
                try
                {
                    currSmartPhone.Browse(URL);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }



            }
        }
    }
}
