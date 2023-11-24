using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public class Player
    {
        public string name;
        public int money;
        public List<Item> Inventory = new List<Item>();
        public List<Poketmon> MyPokemon = new List<Poketmon>();
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
