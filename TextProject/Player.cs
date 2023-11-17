using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{

    public class Pokemon1
    {
        public string name;
        public string type;
        public int level;
        public int fullHp;
        public int fullMp;
        public int hp;
        public int mp;
        public int hungry;
        public bool FallDown;
        public Pokemon1(string name, string type, int level, int hp, int mp)
        {
            this.name = name;
            this.type = type;
            this.level = level;
            this.hp = hp;
            this.mp = mp;
            FallDown = false;
        }
        public void PokemonState()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"타입 : {type}");

        }

    }

    public class Player
    {
        public string name;
        public List<Item> Inventory = new List<Item>();
        public List<Pokemon1> MyPokemon = new List<Pokemon1>();
        public Player(string name)
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
            Console.WriteLine();


        }

        public void GetItem(Item item)
        {
            Inventory.Add(item);
            Console.WriteLine($"{name}이(가) {item.GetName}을(를) 얻었습니다!");
            Console.WriteLine();
        }



    }


}
