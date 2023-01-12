using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Task_7_Final
{
    static class Dialog
    {
        static private List<Product> products;
        static private Order<Delivery> order;
         static public void Run()
        {
            Console.Write("Вы хотите сделать заказ? Если хотите сделать заказ введите Да:");
            if (Console.ReadLine() == "Да")
            {

                products = new List<Product>();
                ProductList();

                order = new Order<Delivery>(products);
                order.MyDelivery = MyDelivery();
                Client client = new Client();
                Console.Write("Введите ФИО клиента: ");
                client.Name = Console.ReadLine();
                Console.Write("Введите номер телефона клиента: ");
                client.Telephone = Console.ReadLine();
                order.MyClient = client;
                order.PrintOrder();

            }
        }
        static public void ProductList()
        {
            bool repeat = true;

            while (repeat)
            {
                AddMyProduct();
                Console.Write("Добавить еще товар? Если хотите добавить товар в заказ введите Да:");
                if (Console.ReadLine() == "Да") continue;
                else
                    repeat = false;
            }


        }

        static public void AddMyProduct()
        {

            Product myProduct = new Product();
            Console.Write("Введите штрихкод: ");
            myProduct.Barcode = Convert.ToInt64(Console.ReadLine());
            Console.Write("Введите наименование: ");
            myProduct.Name = Console.ReadLine();
            Console.Write("Введите цену: ");
            myProduct.Price = Convert.ToDouble(Console.ReadLine());
            products.Add(myProduct);
         }

        static public Delivery MyDelivery()
        {
            Delivery delivery;
            Console.Write("Выберите тип доставки:\n" +
                " 1 Доставка на дом (по умолчанию)\n 2 Доставка в пункт выдачи\n 3 Доставка в розничный магазин\n " +
                "Введите номер: ");
            switch (Console.ReadLine())
            {
                case "2":
                    delivery = new PickPointDelivery();
                    break;
                case "3":
                    delivery = new ShopDelivery();
                    break;
                default:
                    delivery = new HomeDelivery();
                    
                    break;
            }
            Console.Write("Выведите адрес доставки:");
            delivery.Address = Console.ReadLine();
            return delivery;


        }
    }
}
