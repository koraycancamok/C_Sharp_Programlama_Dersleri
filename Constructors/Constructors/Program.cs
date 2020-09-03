using System;
using System.Collections.Generic;

namespace Constructors
{
    public class Product
    {
        public int ProductNumber;
        public string Name;
        public double Price;
        public List<Comment> Comments;

        public Product()
        {
            this.Comments = new List<Comment>();
            this.ProductNumber = (new Random()).Next(111111,999999);
        }
        public Product(int productNumber):this()
        {
            this.ProductNumber = productNumber;
        }
        public Product(int productNumber, string name):this(productNumber)
        {
            this.ProductNumber = productNumber;
            this.Name = name;
        }
    }
    public class Comment
    {
        public int Id;
        public string Text;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var comment = new Comment();
            comment.Id = 1;
            comment.Text = "Samsung S8 güzel bir telefon";

            var p1 = new Product();
            p1.Comments.Add(comment);
            Console.WriteLine("---Comments---");
            foreach (var item in p1.Comments)
            {
                Console.WriteLine(item.Text);
            }
            Console.WriteLine(p1.ProductNumber);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);

            var p2 = new Product(123123);
            p2.Comments.Add(comment);
            Console.WriteLine("---Comments---");
            foreach (var item in p2.Comments)
            {
                Console.WriteLine(item.Text);
            }
            Console.WriteLine(p2.ProductNumber);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Price);

            var p3 = new Product(123123,"Samsung S8");
            p3.Comments.Add(comment);
            Console.WriteLine("---Comments---");
            foreach (var item in p3.Comments)
            {   
                Console.WriteLine(item.Text);
            }
            Console.WriteLine(p3.ProductNumber);
            Console.WriteLine(p3.Name);
            Console.WriteLine(p3.Price);
        }
    }
}
