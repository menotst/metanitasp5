using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserInfo
    {
        public UserInfo(string NameS, int Age)
        {
            this.NameS = NameS;
            this.AgeS = Age;
        }
        public string NameS { get; set; }
        public int AgeS { get; set; }
    }

    class AllInfoUser : UserInfo
    {
        public AllInfoUser(string Family, string Name, int Age) : base(Name, Age)
        {
            this.Family = Family;
        }
        public string Family { get; set; }

        public override string ToString()
        {
            string s = String.Format("Информация о пользователе: \n{0} {1} {2}\n", this.NameS, Family, this.AgeS);
            return s;
        }
    }
    class Info<T> where T : UserInfo
    {
        T[] UserList;
        int i;
        public Info()
        {
            UserList = new T[3];
            i = 0;
        }
        public void Add(T obj)
        {
            if (i == 3) return;
            UserList[i] = obj;
            i++;
            return;
        }
        public void ReWrite()
        {
            foreach (T t in UserList)
                Console.WriteLine(t.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Info<AllInfoUser> database1 = new Info<AllInfoUser>();
            database1.Add(new AllInfoUser("MIkhail", "Tarasov", 31));
            database1.Add(new AllInfoUser("Andrey", "Ivanov", 31));
            database1.Add(new AllInfoUser("Sergey", "Petrov", 31));
            database1.ReWrite();

            Console.ReadKey();
        }
    }
}