using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {

            var phoneNumbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');
            var inputString = Console.ReadLine().Split(' ');

            while (inputString[0] != "done")
            {
                if (inputString[0] == "call")
                {
                    bool check = false;
                    for (int i = 0; i < names.Length; i++)
                    {                      
                        if (inputString[1] == names[i] && check == false)
                        {
                            check = true;
                           
                            if (IsSumOfDigitOdd((phoneNumbers[i])))
                            {
                                Console.WriteLine($"calling { phoneNumbers[i]}...");
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                Console.WriteLine($"calling { phoneNumbers[i]}...");                                
                                Console.Write($"call ended. duration: ");
                                SumToFormatMinSec(phoneNumbers[i]);
                            }
                        }
                        else if(inputString[1] == phoneNumbers[i] && check == false)
                        {
                            check = true;

                            if (IsSumOfDigitOdd((phoneNumbers[i])))
                            {
                                Console.WriteLine($"calling { names[i]}...");
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                Console.WriteLine($"calling { names[i]}...");
                                Console.Write($"call ended. duration: ");
                                SumToFormatMinSec(phoneNumbers[i]);
                            }
                        }
                    }
                }
                else
                {
                    bool check = false;
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (inputString[1] == names[i] && check == false)
                        {
                            check = true;
                            if (IsDifferenceOfDigitOdd((phoneNumbers[i])))
                            {
                                Console.WriteLine($"sending sms to { phoneNumbers[i]}...");
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine($"sending sms to { phoneNumbers[i]}...");
                                Console.WriteLine($"meet me there");
                            }
                        }
                        else if(inputString[1] == phoneNumbers[i] && check == false)
                        {
                            check = true;
                            if (IsDifferenceOfDigitOdd((phoneNumbers[i])))
                            {
                                Console.WriteLine($"sending sms to { names[i]}...");
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine($"sending sms to { names[i]}...");
                                Console.WriteLine($"meet me there");
                            }
                        }
                    }

                }


                inputString = Console.ReadLine().Split(' ');


            }
        }

        private static bool IsDifferenceOfDigitOdd(string phoneNumbers)
        {
            var newPhoneNum = phoneNumbers.ToCharArray();

            var diff = 0;

            for (int i = 0; i < newPhoneNum.Length; i++)
            {            
                if (newPhoneNum[i] >= 48 && newPhoneNum[i] < 58)
                {
                    diff += newPhoneNum[i] -48;
                }

            }

            if (diff % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsSumOfDigitOdd(string phoneNumbers)
        {
            var newPhoneNum = phoneNumbers.ToCharArray();
            var sum = 0;

            for (int i = 0; i < newPhoneNum.Length; i++)
            {             
                if (newPhoneNum[i] >= 48 && newPhoneNum[i] < 58)
                {
                    sum += newPhoneNum[i] - 48;
                }
                
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void SumToFormatMinSec(string phoneNumbers)
        {
            var newPhoneNum = phoneNumbers.ToCharArray();
            var sum = 0;

            for (int i = 0; i < newPhoneNum.Length; i++)
            {
                if (newPhoneNum[i] >= 48 && newPhoneNum[i] < 58)
                {
                    sum += newPhoneNum[i] - 48;
                }

            }

            var min = sum / 60;
            var sec = sum % 60;

            Console.WriteLine("{0:00}:{1:00}",min,sec);
        }
    }
}
