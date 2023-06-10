using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menudelegaet
{
    internal class Program
    {
        public delegate void Menu();
        static void Main(string[] args)
        {
            Menu[] menu = new Menu[5];
            menu[0] += StartGame;
            menu[1] += LoadGame;
            menu[2] += Rules;
            menu[3] += InfoAuthor;
            menu[4] += Exit;


            int indexMenu = 0;
            do
            {
                Console.WriteLine("Input Index");
                indexMenu = Convert.ToInt32(Console.ReadLine());
                if (indexMenu > 0 || indexMenu < 4)
                {
                    menu[--indexMenu]();
                }
            } while (indexMenu != 4);
        }

        public static void StartGame()
        {
            Console.WriteLine("Start Game");
        }

        public static void LoadGame()
        {
            Console.WriteLine("Load Game");
        }

        public static void Rules()
        {
            Console.WriteLine("Rules");
        }
        public static void InfoAuthor()
        {
            Console.WriteLine("Info Author");
        }
        public static void Exit()
        {
            Console.WriteLine("Exit");
        }
    }
}
