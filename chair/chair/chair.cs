using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chair
{
    class Chair
    {
        public int Pos { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public bool StatusBar { get; set; }
        public int Size { get; set; }
        public string Tree { get; set; }
        public int price { get; set; }

        string derevo = "Дерево";
        string plastic = "Пластик";
        public void styl()
        {
            if (Tree == derevo)
            {
                price += 1000;
            }
            else if (Tree == plastic)
            {
                price += 100;
            }
            else
            {
                none();
            }
            }
        public void none()
        {
            if (Tree != derevo && Tree !=plastic)
            {
                Console.WriteLine("ТУТ НЕТ ТАКОГО!");
            }
        }
        }
    }