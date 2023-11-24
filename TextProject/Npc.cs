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
            int choiceNum = int.Parse(Console.ReadLine());
          
            
        }
       
        public void PokemonAbility() //포켓몬 능력 
        {
            Console.Write("보유 포켓몬 : ");
            foreach (Poketmon pokemon in player.MyPokemon)
             {
                 Console.WriteLine($"이름 : {pokemon.Name}");
                Console.WriteLine($"타입 : {pokemon.fulltype}"); //TODO Enum으로 설정되어있는 타입 한국어로 바꿔줘야함
                Console.WriteLine($"현재 레벨 : {pokemon.Level} ");
                Console.WriteLine($"보유 스킬 : {pokemon.Attack_skill}");
                Console.WriteLine($"체력 : {pokemon.FullHp}");
                Console.WriteLine($"공격력 : {pokemon.Damage}");
                Console.WriteLine($"크리티컬 : {pokemon.Critical}");
                Console.WriteLine();
                
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
    public class GymNpc : Npc //체육관 관장
    {

    }
    public class Merchant : Npc //상인
    {


    }
}


