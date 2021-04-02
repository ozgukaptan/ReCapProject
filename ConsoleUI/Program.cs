using Bussines.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities.Results;

namespace ConsoleUI
{
    class Program
    {
        
            
        static void Main(string[] args)
        {
            DateTime rentDate = new DateTime(2022, 1, 1);
            DateTime returnDate = new DateTime(2022, 1, 3);
            Rental rental = new Rental { RentDate = rentDate, ReturnDate = returnDate, CarId = 1, CustomerId = 1, Id = 1 };
            Payment payment = new Payment { Amount= 1200 };

            

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            PaymentManager paymentManager = new PaymentManager(rentalManager);

            IResult result = paymentManager.ReceivePayment(payment, rental);
            Console.WriteLine(result.Success.ToString());
            Console.ReadLine();

            //IResult result = rentalManager.CheckCarRentable(rental);
            Console.WriteLine(result.Success.ToString());
            Console.ReadLine();

            Color color = new Color {Description = "sarı", Name = "a"};
            Car newCar = new Car {  BrandId = 1, ColorId = 1, DealyPrice = 100, Description = "Yeni Araba açıklama", ModelYear = "1990" };
            Car updateCar = new Car { Id = 1, BrandId = 1, ColorId = 2, DealyPrice = 900, Description = "Güncellenen araba fiyat ve rengi değişti  Araba açıklama", ModelYear = "1990" };


            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var cars = carManager.GetCarsByBrandId(1);

            foreach (var car in cars.Data)
            {
                Console.WriteLine(car.BrandId);
            }



            Console.WriteLine("---------------- İlk Araba Listesi ------------------");
            ShowCarList();

            Console.WriteLine();
            //var result = carManager.Add(newCar);
            Console.WriteLine("---------------- Yeni Araba Eklendi ----------------");
            ShowCarList();
            Console.WriteLine();
            newCar.Description = "Yeni araba açıklama Güncellendi";
            carManager.Update(newCar);
            Console.WriteLine("---------------- Yeni Araba Güncellendi ----------------");
            ShowCarList();
            Console.WriteLine();
            carManager.Delete(newCar);
            Console.WriteLine("---------------- Yeni Araba Silindi ----------------");
            ShowCarList();


            //Console.WriteLine();
            //CarDetail carDto1 = carManager.GetAllCarsDtoById(new InMemoryBrandDal(), new InMemoryColorDal(), 1);
            //Console.WriteLine("---------------- Idsi 1 olan Araba ----------------");
            //Console.WriteLine("Markası :  {0}  Model Yılı : {1}  Rengi : {2}  Fiyatı : {3}  Açıklaması : {4}", carDto1.Brand, carDto1.ModelYear.ToString(), carDto1.Color, carDto1.DealyPrice, carDto1.Description);






            void ShowCarList()
            {
                var carDtos = carManager.GetAllCarDetail();
                foreach (CarDetailDto carDto in carDtos.Data)
                {
                  //  Console.WriteLine("Markası :  {0}  Model Yılı : {1}  Rengi : {2}  Fiyatı : {3}  Açıklaması : {4}"  , carDto.BrandName, carDto.ModelYear.ToString(), carDto.ColorName, carDto.DealyPrice, carDto.Description);
                }
            }

            //void ShowColorList()
            //{
            //    List<Color> colors = colorManager.GetAll();
            //    foreach (Color color in colors)
            //    {
            //        Console.WriteLine("Renk Adı  :  {0}  Renk açıklaması : {1}  ", color.Name, color.Description.ToString() );
            //    }
            //}


        }



    }
}
