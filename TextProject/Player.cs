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
            Console.WriteLine($"플레이어 {player.name}님, 환영합니다! {gameName}에 입장합니다. ");
            Thread.Sleep(1500); // 1.5초 동안 프로그램을 멈춤
            Console.Clear();
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
                    Console.Write("                           올바른 숫자를 다시 입력해주세요...");
                    Thread.Sleep(1500); // 1.5초 동안 프로그램을 멈춤
                    Console.Clear();
                    RunGame();
                    
                    break;

            }
        }

        void ChoiceMyPokemon()
        {
            Console.WriteLine("함께 여행을 할 포켓몬을 선택해주세요.");
            //포켓몬 고르는 로직 구현
        }
    }
    public class Item
    {
      public  string name;

    }

    public class Pokemon
    {
        public  string name;
        public string type;
        public int level;
        public int fullHp;
        public int fullMp;
        public int hp;
        public int mp;
        public int hungry;
        public Pokemon(string name, string type, int level, int hp, int mp)
        {
            this.name = name;
            this.type = type;
            this.level = level;
           
            this.hp = hp;
            this.mp = mp;
        }
        public  void  PokemonState()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"타입 : {type}");

        }

    }
   
    public class Player
    {
       public string name;
     public  List<Item> Inventory = new List<Item> ();
     public  List<Pokemon> MyPokemon = new List<Pokemon>();
    public  Player(string name)
        {
            this.name = name;
        }
        public void PlayerStatus()
        {
            Console.WriteLine($"플레이어명 : {name}");
            Console.WriteLine();
            Console.Write($"보유 아이템 : ");
            foreach (Item item in Inventory)
            {
                Console.Write(item);
            }
            Console.WriteLine() ;

          
        }

        public void GetItem(Item item)
        {
            Inventory.Add(item);
            Console.WriteLine($"{name}이(가) {item.name}을(를) 얻었습니다!");
            Console.WriteLine();
        }

      

    }

    public class Npc
    {
        string name;

        public void NpcCommet(Player player)
        {
            Console.WriteLine($"안녕하세요 {player.name}님 무엇을 도와드릴까요?");
        }
       

    }

    public class ODoctor : Npc //오박사
    {
        public void PokemonAbility(Player player) //포켓몬 능력 
        {
            Console.Write("보유 포켓몬 : ");
            foreach (Pokemon pokemon in player.MyPokemon)
            {
                Console.Write(pokemon.name);
                //포켓몬 스킬 //타입 등등
            }
            Console.WriteLine();
        }
    }

    public class Nurse : Npc //간호사
    {
        public void PokemonState(Player player)//포켓몬 상태
        {
            Console.Write("보유 포켓몬 : ");
            foreach (Pokemon pokemon in player.MyPokemon)
            {
                Console.WriteLine($"이름 : {pokemon.name}");
                Console.WriteLine($"현재 체력 : {pokemon.fullHp-pokemon.hp}({pokemon.fullHp} - {pokemon.hp}) ");
                Console.WriteLine($"현재 기력 : {pokemon.fullMp - pokemon.mp}({pokemon.fullMp} - {pokemon.mp}) ");
                Console.WriteLine($"포만감 : {pokemon.hungry}%");



                //포켓몬 스킬 //타입 등등
            }
            Console.WriteLine();
        }

    }
    public class GymNpc : Npc //체육관 관장
    {

    }
    public class Merchant :Npc //상인
    {

    }
}
