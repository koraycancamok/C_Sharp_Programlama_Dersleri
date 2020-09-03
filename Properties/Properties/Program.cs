using System;

namespace Properties
{
    public class Product
    {
        private string _Name;
        #region Name
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Name = value;
                }
                else
                {
                    Console.WriteLine("name alanı gerekli bir alan");
                }
            }
        }
        #endregion
        #region ShortName
        private string _ShortName;
        public string ShortName
        {
            get
            {
                _ShortName = Name.Length > 10 ? Name.Substring(0, 10) + "..." : Name;
                return _ShortName;
            }
        }
        #endregion
        #region Price
        private double _Price;
        public void SetPrice(double price)
        {
            if (price < 0)
            {
                _Price = 0;
            }
            else
            {
                _Price = price;
            }
        }
        public double GetPrice()
        {
            return _Price;
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product();
            p1.Name = "İphone 8 Çok Güzel Bir Telefon";
            p1.SetPrice(2000);
            Console.WriteLine(p1.GetPrice());
            Console.WriteLine(p1.ShortName);

            var p2 = new Product();
            p2.Name = "2";
        }
    }
}
