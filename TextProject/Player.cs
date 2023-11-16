using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public class GameManager
    {
        
        string gameName = "Pokemon World";

        public void RunGame()
        {
            StartDisplay();
            StartOrExit();

        }
       void StartDisplay()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine($"*                                Welcome to {gameName}                                    *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        void StartGame()
        {
            Console.Write("플레이어 이름을 입력해주세요: ");
            Player player = new Player(Console.ReadLine());
            Console.WriteLine($"플레이어 {player.name}님, 환영합니다! 게임을 시작합니다. ");    
        }

        void StartOrExit() 
        {
            
            Console.WriteLine("                                     1. 게임시작");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                       2 나가기");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                    case 1:
                    Console.Clear();
                    StartGame();
                    break;

                    case 2:
                    Console.WriteLine("게임을 종료합니다");
                    break;

                    default :
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                        올바른 숫자를 다시 입력해주세요...");
                    Thread.Sleep(1500); // 1초 동안 프로그램을 멈춤
                    Console.Clear();
                    RunGame();
                    
                    break;

            }
        }
    }
    public class Item
    {
      

    }

    public class Pokemon
    {

    }
    public class Player
    {
       public string name;
       List<Item> Inventory = new List<Item> ();
       List<Pokemon> MyPokemon = new List<Pokemon>();
    public  Player(string name)
        {
            this.name = name;
        }


    }
}
