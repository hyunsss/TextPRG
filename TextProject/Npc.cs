using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
  
    public class Npc
    {
        Gamemanager gamemanager;
        public Player player;
        public string name;
       

       

        public void NpcCommet()
        {
            Console.WriteLine($"안녕하세요 {player.name}님 무엇을 도와드릴까요?");
        }


    }

    public class ODoctor : Npc //오박사
    {
        int pokemonCount = 0;
        


        public void NpcCommet()
        {
            Console.WriteLine($" {player.name} 자네 무슨 일 때문에 왔는가?");
            for (int i = 0; i < player.MyPokemon.Count; i++)
            {
                Console.WriteLine($"1. {player.MyPokemon[i].Name}의 스테이터스를 확인하러 왔습니다!");
                pokemonCount++;
            }
            Console.WriteLine($"{pokemonCount}. 나가기");
            string playerInput = Console.ReadLine();

            if(int.TryParse(playerInput, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("자네가 보유하고 있는 포켓몬들의 능력치를 보여주지");
                        PokemonAbility();
                        return;
                }
            }
            
          
            
        }
       
        public void PokemonAbility() //포켓몬 능력 
        {
            int i = 1;
            foreach (Poketmon pokemon in player.MyPokemon)
             {
                Console.WriteLine($"{i}번째 포켓몬");
                 Console.WriteLine($"이름 : {pokemon.Name}");
                Console.WriteLine($"타입 : {pokemon.fulltype}"); //TODO Enum으로 설정되어있는 타입 한국어로 바꿔줘야함
                Console.WriteLine($"현재 레벨 : {pokemon.Level} ");
                Console.WriteLine($"보유 스킬 : {pokemon.Attack_skill}");
                Console.WriteLine($"체력 : {pokemon.FullHp}");
                Console.WriteLine($"공격력 : {pokemon.Damage}");
                Console.WriteLine($"크리티컬 : {pokemon.Critical}");
                Console.WriteLine();
                i++;
                
             }
            Console.WriteLine();
        }
    }

    public class Nurse : Npc //간호사
    {
       
        public void PokemonState()//포켓몬 상태
        {
            Console.Write("보유 포켓몬 : ");
             foreach (Poketmon pokemon in player.MyPokemon)
             {
                 Console.WriteLine($"이름 : {pokemon.Name}");
                 Console.WriteLine($"현재 체력 : {pokemon.FullHp-pokemon.Hp}({pokemon.FullHp} - {pokemon.Hp}) ");
                
                Console.WriteLine();
                Console.WriteLine();


                //포켓몬 스킬 //타입 등등
            }
            Console.WriteLine();
        }

    }
    public class JangChungGymNpc : Npc //체육관 관장
    {
        string gymName = "장충 체육관";
        public void NpcCommet()
        {
            Console.WriteLine($"장충체육관에 온걸 환영하네!");
        }
    }

    public class GoyangGymNpc : Npc //체육관 관장
    {
        string gymName = "고양 체육관";
        public void NpcCommet()
        {
            Console.WriteLine($"우리 체육관에는 무슨일이지?");
        }
    }
    public class SeoulGymNpc : Npc //체육관 관장
    {
        string gymName = "서울 체육관";
        public void NpcCommet()
        {
            Console.WriteLine($"서울체육관은 처음인가?");
        }
    }

    public class Merchant : Npc //상인
    {

        Item item;
        public void NpcCommet()
        {
            Console.WriteLine($" {player.name}! 찾는 물건이 있나?");
            Console.WriteLine("1. 네 있습니다.");
            Console.WriteLine("2. 아...없네요 다음에 오겠습니다.(나가기)");
            string str =  Console.ReadLine();
            if(int.TryParse(str, out int iValue) )
            {
                if(iValue == 1)
                {
                 
                    Console.WriteLine($"이 중에 어떤 것인가?");
                   //TODO 아이템 LIST로 만들어서 상저
                   for(int i = 0; i < item.items.Count; i++)
                    {
                        Console.WriteLine($"{i}. 아이템명 : {item.items[i].GetName}");
                        Console.WriteLine($"{i}. 아이템가격 : {item.items[i].GetPrize}");
                        Console.WriteLine($"{i}. 아이템설명 : {item.items[i].GetItemMessage}");
                    }
                    
                }
                if(iValue == 2)
                {

                }
            }
        }

     }
}


