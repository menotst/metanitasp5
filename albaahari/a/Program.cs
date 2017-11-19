using System;

namespace a
{
    public abstract class Asset
    {
        public string Name;
        public virtual decimal Liability
        {
            get { return 0; }
        }
        public abstract decimal Netvalue { get; }
    }

    public class Stock : Asset
    {
        public decimal CurrentPrice;
        public long SharesOwned;
        public override decimal Netvalue
        {
            get { return CurrentPrice * SharesOwned; }
        }
    }
    //public class House : Asset
    //{
    //    public decimal Mortgage;
    //    public override decimal Liability
    //    {
    //        get
    //        {
    //            return Mortgage;
    //        }
    //    }
    //}    
    class Program
    {
        public static void Display(Asset asset)
        {
            Console.WriteLine(asset.Name);
        }
        static void Main(string[] args)
        {
            //Stock msft = new Stock
            //{
            //    Name = "MSFT",
            //    SharesOwned = 1000
            //};

            //House mansion = new House
            //{
            //    Name = "McMansion", Mortgage = 25000            
            //};
            //Asset a = mansion;
            //Asset b = new Asset();
            //Console.WriteLine(mansion.Liability);
            //Console.WriteLine(a.Liability);
            //Console.WriteLine(b.Liability);


            //Asset a = msft; //вверх
            //Stock s = (Stock)a;
            //if (a is Stock)
            //    Console.Write(((Stock)a).SharesOwned);
            //Console.WriteLine(s.);
            //Console.WriteLine(a.Name);
            //Console.WriteLine(s.SharesOwned);
            //Console.WriteLine(msft.Name);
            //Console.WriteLine(msft.SharesOwned);

            //House h = new House();
            //Asset a1 = h;
            //Stock s1 = (Stock)a1;

            //Asset a = new Asset();           
            //Stock s = a as Stock;
            //if (s != null)
            //{
            //    Console.WriteLine(s.SharesOwned);
            //}
            //long shares = ((Stock)a).SharesOwned;
            //long shares1 = (a as Stock).SharesOwned;            

            //House mansion = new House
            //{
            //    Name="Mansion",
            //    Mortgage=25000
            //};
            //Console.WriteLine(mansion.Name);
            //Console.WriteLine(mansion.Mortgage);
            //Display(msft);
            //Display(mansion);
            //Console.Write(a==msft);            

            Console.ReadKey();
        }     
    }
}