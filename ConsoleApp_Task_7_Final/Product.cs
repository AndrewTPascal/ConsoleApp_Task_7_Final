using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Task_7_Final
{
    // Добавил свой класс Товар
    class Product
    {
        // Штрихкод товара, минимальная длина 8 символов
        // Использование protected
        protected long barcode;
        public long Barcode
        {
            get { return barcode; }
            set
            {
                if (value.ToString().Length > 7 && value.ToString().Length < 14) barcode = value;
            }

        }


        // Наименование товара
        public string Name;
        // Цена товара. Проверка поля.
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
            }

        }


    }

}
