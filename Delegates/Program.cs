using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegateText(string text);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate();

            MyDelegateText myDelegateText = customerManager.SendMessageTxt;
            myDelegateText += customerManager.ShowAlertTxt;

            myDelegateText("Merhaba");

            myDelegate -= customerManager.SendMessage;

            //Func Demo
            Matematik matematik = new Matematik();

            Func<int, int, int> add = matematik.Add;
            Console.WriteLine(add(6, 1));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(1, 1000);
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessageTxt(string text)
        {
            Console.WriteLine("Mesaj : {0}", text);
        }

        public void ShowAlertTxt(string text)
        {
            Console.WriteLine("Uyarı : {0}", text);
        }
    }

    public class Matematik
    {
        public int Add(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
