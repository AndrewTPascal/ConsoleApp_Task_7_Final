using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Task_7_Final
{
    // Доставка
    abstract class Delivery
    {
        // Тип доставки
        public string DType;
        
        public string Address;
        public Delivery()
        { }

        // Переопределение метода
        public virtual void PrintDelivery()
        { Console.WriteLine(DType, Address); }
    }

    // Доставка на дом
    class HomeDelivery : Delivery
    {
        /* ... */
        static private string type = "Доставка на дом";

        // Использование protected
        protected CourierCompany courier;
        public HomeDelivery()
        {
            DType = type;
            courier = new CourierCompany();
        }

        // Переопределение метода
        public override void PrintDelivery()
        { Console.WriteLine(DType, Address, courier.Name); }

        // Использование обощенного метода
        public void PrintAddress<T>(T delivery) where T : Delivery
        { Console.WriteLine(delivery.Address); } 

    }

    // Добавил свой класс Служба доставки
    class CourierCompany
    {
       
        // Название службы доставки
        public string Name;
    }

    // Доставка в пункт выдачи
    class PickPointDelivery : Delivery
    {
        static private string type = "Доставка в пункт выдачи";
        // Название магазина
        public string Name;
        public PickPointDelivery()
        {
            DType = type;
        }

    }

    // Доставка в магазин
    class ShopDelivery : Delivery
    {
        static private string type = "Доставка в розничный магазин";
        public string Name;

        public ShopDelivery()
        {
            DType = type;
        }
    }


}
