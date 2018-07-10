using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Modul
{
   public abstract class PhoneB
    {
        private string denominationSubj;
        private string adress;
        private string telephoneNumber;
        private String dateOfBirth; 
        internal static int indexOrder = -1;
       
        public static object[] dataNotation;
        protected static int numNotations;
       
        public PhoneB()
        {
            denominationSubj = "";
            adress = "";
            telephoneNumber = "";
            dateOfBirth = "data is not known.";
             numNotations++;
        }


       
        public static void MakePhoneBook(int _volPhBook)
        {
            dataNotation = new PhoneB[_volPhBook];
        }
       
        public PhoneB this[int index]
        {
            set { dataNotation[index] = value; }
            get { return (PhoneB)dataNotation[index]; }
        }
        public string Title
        {
            get { return denominationSubj; }
            set { denominationSubj = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Telefon
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

      
        public static int GetNumOfNotations()
        {
            return numNotations;
        }

      
        public abstract void ShowNotation(int _numNotation);
        public abstract object call(object currZap, int i);
        public void TruncNotation(int _numNotation)
        {
            Console.WriteLine("{0} проживает по адресу {1}, родился: \"{2}\", его номер телефона: {3}.", denominationSubj, adress, dateOfBirth, telephoneNumber);
        }
    }
}
