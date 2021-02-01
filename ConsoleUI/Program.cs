using Bussines.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        
            
        static void Main(string[] args)
        {
            Car newCar = new Car { Id = 7, BrandId = 1, ColorId = 1, DealyPrice = 600, Description = "Yeni Araba açıklama", ModelYear = 1990 };
            Car updateCar = new Car { Id = 7, BrandId = 1, ColorId = 2, DealyPrice = 900, Description = "Güncellenen araba fiyat ve rengi değişti  Araba açıklama", ModelYear = 1990 };


            CarManager carManager = new CarManager(new InMemoryCarDal());


            Console.WriteLine("---------------- İlk Araba Listesi ------------------");
            showCarList();

            carManager.Add(newCar);
            Console.WriteLine("---------------- Yani Araba Eklendi ----------------");
            showCarList();

            carManager.update(updateCar);
            Console.WriteLine("---------------- Yani Araba Güncellendi ----------------");
            showCarList();

            carManager.delete(updateCar);
            Console.WriteLine("---------------- Yani Araba Silindi ----------------");
            showCarList();




            void showCarList()
            {
                List<CarDto> carDtos = carManager.GetAllCarsDto(new InMemoryBrandDal(), new InMemoryColorDal());
                foreach (CarDto carDto in carDtos)
                {
                    Console.WriteLine("Markası :  {0}  Model Yılı : {1}  Rengi : {2}  Fiyatı : {3}  Açıklaması : {4}"  , carDto.Brand, carDto.ModelYear.ToString(), carDto.Color, carDto.DealyPrice, carDto.Description);
                }
            }

        }



    }
}
