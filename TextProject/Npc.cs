using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public class Npc
    {

        public string name;

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
            /* foreach (Pokemon1 pokemon in player.MyPokemon)
             {
                 Console.Write(pokemon.name);
                 //포켓몬 스킬 //타입 등등
             }*/
            Console.WriteLine();
        }
    }

    public class Nurse : Npc //간호사
    {
        public void PokemonState(Player player)//포켓몬 상태
        {
            Console.Write("보유 포켓몬 : ");
            /* foreach (Pokemon1 pokemon in player.MyPokemon)
             {
                 Console.WriteLine($"이름 : {pokemon.name}");
                 Console.WriteLine($"현재 체력 : {pokemon.fullHp-pokemon.hp}({pokemon.fullHp} - {pokemon.hp}) ");
                 Console.WriteLine($"현재 기력 : {pokemon.fullMp - pokemon.mp}({pokemon.fullMp} - {pokemon.mp}) ");
                 Console.WriteLine($"포만감 : {pokemon.hungry}%");



                 //포켓몬 스킬 //타입 등등
             }*/
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


