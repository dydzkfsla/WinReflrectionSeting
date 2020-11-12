using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WinReflrectionSeting
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        string blood = "O";
        public string Boold { get => blood; }


        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return Name + Age.ToString();
        }

        public void DeepCopy(Person old)
        {
            Type t = this.GetType();
            foreach (PropertyInfo prop in t.GetProperties())
            {
                prop.SetValue(this, prop.GetValue(old));
            }
        }
    }

    class Program2
    {
        static void Main()
        {   // DeepCopy
            Person p1 = new Person("홍길동", 30);
            Person p2 = p1;
            p2.Name = "김개똥";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Person p3 = new Person();
            DeepCopy(p1, p3);

            p3.Name = "아이유";
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p3.ToString());

            p1.DeepCopy(p3);
            Console.WriteLine(p1.ToString());

            Console.ReadLine();
        }

        static void DeepCopy<T>(T oldobj, T newobj)
        {
            //1. GetType()
            //2. typof()

            Type t1 = oldobj.GetType();
            Type t2 = newobj.GetType();
            foreach (PropertyInfo prop in t1.GetProperties())
            {
                if (prop.CanWrite && prop.CanRead)
                    prop.SetValue(newobj, prop.GetValue(oldobj));
            }
        }
    }
}
