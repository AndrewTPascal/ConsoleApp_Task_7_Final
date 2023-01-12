using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Task_7_Final
{
    // Заказ
    class Order<TDelivery> where TDelivery : Delivery
    {
        // Вид доставки: на дом, в пункт выдачи, в магазин
        public TDelivery MyDelivery;

        // Счетчик заказов
        static private int autoNoumeration = 0;
        // Номер заказа
        public int Number;

        // Клиент
        public Client MyClient;

        //Описание
        public string Description;

        // Массив с товарами
        private List<Product> products;

        // Сумма заказа
        private double Sum = 0;

        public Order()
        {
            autoNoumeration += 1;
            Number = autoNoumeration;


        }
        public Order(List<Product> products) : this()
        {
            this.products = products;
         }

        // Индексаторы
        public Product this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < products.Count)
                {
                    return products[index];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < products.Count)
                {
                    products[index] = value;
                }
            }


        }


        //Показать адрес доставки
        public void DisplayAddress()
        {
            Console.WriteLine(MyDelivery.Address);
        }

        // Распечатать заказ с общей суммой к оплате
        public void PrintOrder()
        {
            Console.WriteLine("\nЗаказ сформирован!");
            Console.WriteLine("Номер заказа: {0}, Вид доставки:{1}", Number, MyDelivery.DType);
            Console.WriteLine("Адрес доставки: " + MyDelivery.Address);
            Console.WriteLine("Клиент: {0} Телефон: {1}", MyClient.Name, MyClient.Telephone);
            Console.WriteLine("__________________________");
            Console.WriteLine("\nТовары: ");
            foreach (var i in products) 
            { 
                Console.WriteLine("{0}\t{1}", i.Name, i.Price);
                Sum += i.Price;
            }
            Console.WriteLine("__________________________");
            Console.WriteLine("Сумма заказа: " + Sum);
        }


    }

}
