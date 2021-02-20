using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;



namespace Console
{
    class program
    {
        static void Main(string[] args)
        {
           /* BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var brand in brandManager.GetAll()) {
                Console.WriteLine(brand.BrandName);
            }*/
        }
    }
}

/*
ProductManeger productManager = new ProductManeger(new InMemory());
foreach (var car in productManager.GetAll())
{

    Console.WriteLine(product.ProductName+"/"+product.CategoryName);

}

*/