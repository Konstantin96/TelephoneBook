using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PhoneBook.Modul;


namespace TelephoneDirectory
{
    class Program
    {
        static void Main()
        {
            int _kolCitizens, _kolFriends, _kolOrganizations, _kolZap;
            Console.Write("Введите лимит справочника на количество записей \"граждан\": ");
            _kolCitizens = int.Parse(Console.ReadLine());
            Console.Write("Введите лимит справочника на количество записей \"друзей\": ");
            _kolFriends = int.Parse(Console.ReadLine());
            Console.Write("Введите лимит справочника на количество записей по \"организациям\": ");
            _kolOrganizations = int.Parse(Console.ReadLine());
            Console.Write("Итого лимит справочника на количество записей: " + (_kolZap = _kolOrganizations + _kolFriends + _kolCitizens));
            PhoneB.MakePhoneBook(_kolZap);
            Person _citizen = new Person(_kolCitizens);
            Friend _friend = new Friend(_kolFriends);
            Organization _organization = new Organization(_kolOrganizations);
          

            byte k = 0;
            for (int i = 0; i < _kolCitizens; i++)
            {
                _citizen[i] = (Person)_citizen.call(_citizen, i); 
                Console.WriteLine("");
                Console.WriteLine("Количество записей в телефонном справочнике = {0}\n", PhoneB.GetNumOfNotations());
            }

            for (int i = 0; i < _kolFriends; i++)
            {
                _friend[i] = (Friend)_friend.call(_friend, i);
                Console.WriteLine("");
                Console.WriteLine("Количество записей в телефонном справочнике = {0}\n", PhoneB.GetNumOfNotations());
            }

            for (int i = 0; i < _kolOrganizations; i++)
            {
                _organization[i] = (Organization)_organization.call(_organization, i);
                Console.WriteLine("");
                Console.WriteLine("Количество записей в телефонном справочнике = {0}\n", PhoneB.GetNumOfNotations());
            }
            int ordZap = 1; k = 0;
            Console.WriteLine("Список всех записей:\n");
           
            for (int i = 0; i < _kolCitizens; i++)
            {
                Console.Write((ordZap++) + ".- ");
                _citizen[i].ShowNotation(i);
               
            }

            Thread.Sleep(1000);
            for (int i = 0; i < _kolFriends; i++)
            {
                Console.Write((ordZap++) + ".- ");
                _friend[i].ShowNotation(i);
            }

            Thread.Sleep(1000);
            for (int i = 0; i < _kolOrganizations; i++)
            {
                Console.Write((ordZap++) + ".- ");
                _organization[i].ShowNotation(i);
            }

            Console.WriteLine("\nМожно просмотреть данные по конкретной категории записей справочника:\nВведите фамилию искомого лица или название организации:");
            string searchZapis = Console.ReadLine();
            bool stop = true; string theEnd = "stop";
            while (stop)
            {
                k = 0;
                foreach (PhoneB search in PhoneB.dataNotation)  
                    if (search.Title == searchZapis)
                    {
                        Console.WriteLine("Данные по указанной фамилии (названии организации):\n");
                        Console.WriteLine(search.ToString());
                        k++;
                    }

                if (k == 0)
                    Console.WriteLine("Данные по указанной фамилии (названии организации) не найдены.");
                Console.WriteLine("Для выхода из процедуры поиска наберите \"stop\".\nЧтобы продолжить поиск: Введите фамилию искомого лица или название организации: ");
                searchZapis = Console.ReadLine();
                if (theEnd == searchZapis) stop = false;
            }
            Console.WriteLine("The end");
            Console.ReadKey(true);
        }
    }
}
