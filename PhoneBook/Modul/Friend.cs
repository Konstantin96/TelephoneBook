using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Modul
{
    public class Friend : PhoneB
    {
        private static int numFriendInPhoneBook = 0;
        private Friend[] friends;
        public Friend() : base()
        {
            numFriendInPhoneBook++; 
        }

        public Friend(int i)
        {
            friends = new Friend[i];
        }
        public static int GetNumOfFriends()
        {
            return numFriendInPhoneBook;
        }
        public new Friend this[int index]
        {
            get { return friends[index]; }
            set { friends[index] = value; }
        }
        public override object call(object currZap, int i)
        {
            friends[i] = new Friend(); numNotations++; numFriendInPhoneBook++;
            Console.WriteLine("Введите информацию по {0}-й записи друзей: ", numFriendInPhoneBook);
            Console.Write("Введите фамилию и имя гражданина: ");
            friends[i].Title = Console.ReadLine();
            Console.Write("Адрес: ");
            friends[i].Adress = Console.ReadLine();
            Console.Write("Телефон: ");
            friends[i].Telefon = Console.ReadLine();
            Console.Write("Дату рождения: ");
            friends[i].DateOfBirth = Console.ReadLine();
            dataNotation[++indexOrder] = new Friend();
            dataNotation[indexOrder] = friends[i];
            return friends[i];
        }

        public override string ToString()
        {
            return (this.Title + " проживает по адресу: " + this.Adress + " родился: " + this.DateOfBirth + " его номер телефона: " + this.Telefon);
        }
        public override void ShowNotation(int i)
        {
            Console.WriteLine("{0}, проживает по адресу: {1}, родился: {2}, его номер телефона: {3}.", this.Title, this.Adress, this.DateOfBirth, this.Telefon);
        }
    }
}
