using PhoneBook.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Modul
{
   public  class Person : PhoneB, IorderCustoms
    {
        private Person[] citizen;
        private static int numCitizensInPhoneBook = 0;
        public Person() : base()
        {
            numCitizensInPhoneBook++;  
        }
        public Person(int i)
        {
            citizen = new Person[i];
        }
        public void push(object item)
        {
            Person[] temp = { };
            if (numCitizensInPhoneBook == citizen.Length - 1)
                temp = new Person[citizen.Length + 1];
            for (int i = 0; i < citizen.Length; i++) temp[i] = citizen[i];
            citizen = temp;
            citizen[numCitizensInPhoneBook] = (Person)item;
        }

        public static int GetNumOfCtzn()
        {
            return numCitizensInPhoneBook;
        }
        public new Person this[int index]
        {
            get { return citizen[index]; }
            set { citizen[index] = value; }
        }
        public override string ToString()
        {
            return (this.Title + " проживает по адресу: " + this.Adress + " его номер телефона: " + this.Telefon);
        }

        public override object call(object currZap, int i)
        {
            citizen[i] = new Person(); numNotations++; numCitizensInPhoneBook++;
            Console.WriteLine("Введите информацию по {0}-й записи граждан: ", numCitizensInPhoneBook);
            Console.Write("Введите фамилию и имя гражданина: ");
            citizen[i].Title = Console.ReadLine();
            Console.Write("Адрес: ");
            citizen[i].Adress = Console.ReadLine();
            Console.Write("Телефон: ");
            citizen[i].Telefon = Console.ReadLine();
            dataNotation[++indexOrder] = new Person();
            dataNotation[indexOrder] = citizen[i];
            return citizen[i];
        }
        public override void ShowNotation(int i)
        {
            Console.WriteLine("{0}, проживает по адресу: {1}, его номер телефона: {2}", this.Title, this.Adress, this.Telefon);
        }
    }
}
