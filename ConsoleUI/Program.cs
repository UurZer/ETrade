using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EfProductDal efProductDal = new EfProductDal();

            efProductDal.Add(new Product
            {
                CategoryId = 2,
                Name = "Su",
                Active = true,
                BrandId = 1,
                Code = "WTR01",
                CreateDate = DateTime.Now,
                Price = 2
            });
            
            foreach (var item in efProductDal.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
