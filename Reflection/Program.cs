using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(5, 7);
            //Console.WriteLine(dortIslem.Topla(2, 3));
            //Console.WriteLine(dortIslem.Topla2());

            //Type tip = typeof(DortIslem);
            //DortIslem instance = (DortIslem) Activator.CreateInstance(tip, 5, 7);
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            //var tip = typeof(DortIslem);
            //var instance = Activator.CreateInstance(tip, 9, 4);
            //var methodInfo = instance.GetType().GetMethod("Topla2");
            //Console.WriteLine(methodInfo.Invoke(instance, null));

            var tip = typeof(DortIslem);
            var instance = Activator.CreateInstance(tip);
            var methodInfos = instance.GetType().GetMethods();

            foreach (var info in methodInfos)
            {
                Console.WriteLine("Method Adı : {0}", info.Name);

                foreach (var parametersInfo in info.GetParameters())
                {
                    Console.WriteLine("Method Parametre Adı : {0}", parametersInfo.Name);
                }

                foreach (var attributeInfo in info.GetCustomAttributes())
                {
                    Console.WriteLine("Method Attribute Adı : {0}", attributeInfo);
                }

                Console.WriteLine("---------------");
            }

            Console.ReadLine();
        }
    }

    class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            this._sayi1 = sayi1;
            this._sayi2 = sayi2;
        }

        public DortIslem()
        {

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Bu bir method")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        string _value;
        public MethodNameAttribute(string value)
        {
            _value = value;
        }
    }
}
