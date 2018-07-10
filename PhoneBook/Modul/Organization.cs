using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Modul
{
    public class Organization : PhoneB
    {
        private static int numOrgnzdInPhoneBook = 0;
        private string fax;
        private string clerk;
        private Organization[] organizations;
        public Organization() : base()
        {
             numOrgnzdInPhoneBook++; 
        }

        public Organization(int i)
        {
            organizations = new Organization[i];
        }
        public static int GetNumOfOrganizations()
        {
            return numOrgnzdInPhoneBook;
        }
        public new Organization this[int index]
        {
            get { return organizations[index]; }
            set { organizations[index] = value; }
        }
        public override object call(object currZap, int i)
        {
            organizations[i] = new Organization(); numNotations++; numOrgnzdInPhoneBook++;
            Console.WriteLine("Введите информацию по {0}-й записи организаций ", numOrgnzdInPhoneBook);
            Console.Write("Введите наименование организации: ");
            organizations[i].Title = Console.ReadLine();
            Console.Write("Адрес: ");
            organizations[i].Adress = Console.ReadLine();
            Console.Write("Телефон: ");
            organizations[i].Telefon = Console.ReadLine();
            Console.Write("Факс: ");
            organizations[i].Fax = Console.ReadLine();
            Console.Write("Введите данные контактного лица организации (фамилию и имя): ");
            organizations[i].Clerk = Console.ReadLine();
            dataNotation[++indexOrder] = new Organization();
            dataNotation[indexOrder] = organizations[i];
            return organizations[i];
        }
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public string Clerk
        {
            get { return clerk; }
            set { clerk = value; }
        }

        public override string ToString()
        {
            return (this.Title + " находится по адресу: " + this.Adress + " номер телефона: " + this.Telefon + " номер факса: " + this.Fax + " контактное лицо:" + this.clerk);
        }
        public override void ShowNotation(int i)
        {
            Console.WriteLine("\"{0}\", находится по адресу: {1}, номер телефона: {2}, номер факса: {3}, контактное лицо: {4}", this.Title, this.Adress, this.Telefon, this.Fax, this.clerk);
        }
    }
}
