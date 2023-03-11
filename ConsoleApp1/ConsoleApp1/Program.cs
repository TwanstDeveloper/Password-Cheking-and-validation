using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password");
            string psenter=Console.ReadLine();
            Console.WriteLine("chek password");
            Program obj = new Program();
            obj.chekpass(psenter);

            Console.ReadKey();
        }
    
        void chekpass(string pass)
        {
            bool u = false;
            bool l = false;
            bool n = false;
            bool s = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i]))
                {
                    u=true;
                }else if (char.IsLower(pass[i]))
                {
                    l=true;
                }
                else if (char.IsDigit(pass[i]))
                {
                    n = true;
                }
                else { 
                s=true;
                }
            }
            if (pass.Length<8) {
                Console.WriteLine("Bbura La 8 pit kamtra");

            }
            else if (u==true&&l==true&&n==true&&s==true)
            {
                Console.WriteLine("Your password is secure and you're all set!");
            } 
            else if (u==true&&l==true&&n==true)
            {
                Console.WriteLine("Strong");
            }
            else if (u == true && l == true&& s == true)
            {
                Console.WriteLine(" Strong");
            }
            else if (u == true && l == true )
            {
                Console.WriteLine("weak Password");
            }
            else if (n == true && s == true)
            {
                Console.WriteLine(" Weak Password");
            }
            else
            {
                Console.WriteLine("Please Try Again");
            }
        }

    }
}
