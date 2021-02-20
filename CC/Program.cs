using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace CC
{
    class Program
    {

        static void Main(string[] args)
        {

            //ColorManagerTest();
            // BrandManagerTest();
            //CarManagerTest();
            //UserManagerTest();

            Console.ReadLine();
        }

        private static void ColorManagerTest()
        {
            ColorManager color = new ColorManager(new EFColorDal());
            var result = color.GetAll();
            if (result.Success)
            {
                foreach (var colors in result.Data)
                {
                    Console.WriteLine(colors.Id);
                    Console.WriteLine(colors.ColorName);

                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void BrandManagerTest()
        {
            BrandManager brandmaneger = new BrandManager(new EFBrandDal());
            var result = brandmaneger.GetAll();
            if (result.Success)
            {
                foreach (var brands in result.Data)
                {
                    Console.WriteLine(brands.BrandId);
                    Console.WriteLine(brands.BrandName);

                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void CarManagerTest()
        {
            CarManager carmaneger = new CarManager(new EfCarDal());
            var result = carmaneger.GetAll();
            if (result.Success)
            {
                foreach (var cars in result.Data)
                {
                    Console.WriteLine(cars.BrandId);
                    Console.WriteLine(cars.CarId);

                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        //private static void UserManagerTest()
        //{
        //    UserManager usermaneger = new UserManager(new EfUserDal());
        //    var result =usermaneger.Add(new User {FirstName="Ezgi",LastName=" Ekici",});
        //    if (result.Success)
        //    {
        //        foreach (User  user in usermaneger.GetAll().Data)
        //        {
        //            Console.WriteLine(user.LastName);
        //            Console.WriteLine(user.Password);

        //        }
        //        Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
        
       
    }




