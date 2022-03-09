using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezba25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;

            do
            {
                Console.Clear();
                Console.WriteLine("QA telefonski imenik \n");
                Console.WriteLine("1.Unos novog imena");
                Console.WriteLine("2.Unos novog imena");
                Console.WriteLine("3.Pretraga");
                Console.WriteLine("Q.Kraj rada");
                choice = Console.ReadLine();


                if (choice == "1")
                {
                    AddNewName();
                }

            } while (choice.ToUpper() != "Q");

        }

        static void AddNewName()
        {
            string firstName, lastName, address, phone, choice;

            do
            {
                Console.Write("Unseite ime>");
                firstName = Console.ReadLine();
                Console.Write("Unseite prezime>");
                lastName = Console.ReadLine();
                Console.Write("Unseite adresu>");
                address = Console.ReadLine();
                Console.Write("Unseite telefon>");
                phone = Console.ReadLine();

                FileMenagment.Store(firstName,lastName,address,phone);

                Console.WriteLine("\n Da li zelite unos novog imena?Ukoliko zelite otkucajte slovo 'Y',ili ENTER ukoliko zelite prekinete");
                choice = Console.ReadLine();
                Console.WriteLine("");


            } while (choice.ToUpper() == "Yes");
        }
    }
}
