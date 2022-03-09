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
                Console.WriteLine("2.Listanje imena");
                Console.WriteLine("3.Pretraga");
                Console.WriteLine("Q.Kraj rada");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewName();
                        break;
                    case "2":
                        ListNames();
                        break;
                    case "3":
                        SearchForName();
                        break;
                    case "Q":
                        
                        break;
                    default:
                        break;
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

        static void ListNames()
        {
            Console.Clear();
            DispayNames(FileMenagment.Read());
           
            
        }

        static void SearchForName()
        {
            string search;
            Console.Write("Unesite termin za pretragu(mora da sadrzi najmanje 3 slova)>");
            search = Console.ReadLine();
            if ((search == "")|| (search.Length<3))
            {
                return;
            }
            List<string> searchResults = new List<string>();
            List<string> listOFnames =FileMenagment.Read();
            foreach(string name in listOFnames)
            {
                if (name.ToUpper().Contains(search.ToUpper()))
                {
                    searchResults.Add(name);
                }
            }
            DispayNames(searchResults);
        }
        static void DispayNames(List<string> listOFNames)
        {
            Console.WriteLine("Ime\tPrezime\t\tTelefon\t\t\tAdresa");
            Console.WriteLine("--------------------------------------------");

            foreach (string name in listOFNames)
            {
                string[] details;  
                details = name.Split(';');
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", details[0], details[1], details[3], details[2]);
            }
            Console.ReadKey();
        }
    }
}
