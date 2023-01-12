using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Task_7_Final
{
    // Добавил свой класс Клиент
    class Client
    {
        public string Name;
        public string Telephone;
       
        public Client() 
        { }

        public Client(string name, string telephone) 
        {
            Name = name;
            Telephone = telephone;
        }

    }
}
