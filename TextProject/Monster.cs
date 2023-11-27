using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    internal class Monster : Poketmon
    {

        public void getcatch()
        {
            Console.WriteLine("{0}에게 포켓몬볼을 던졌다", this.Name);
            if (this.Hp < this.FullHp / 4)
            {
                Console.WriteLine("{0}이 울부짖으며 포켓몬볼에 들어갔다.{1}", this.Name, this.Roar);
                Console.WriteLine("포켓몬을 획득했습니다!!");
            }
            else
            {
                Console.WriteLine("{0}이 포켓몬볼에서 튀어나왔다.", this.Name);
            }

            // Player.getPokemon(); // 포켓몬 획득 기믹 내일 얘기해 보고 힘들거 같으면 빼도 ㄱㅊ
        }
        public void getHp()
        {
            this.Hp = Hp;
        }

        public void Monster_death(Monster monster)
        {
            Console.WriteLine("{0}를 쓰러트렸다!!", Name);
            Console.WriteLine("{0}.... 털썩", Roar);
            monster.Death = true;
        }
        

    }
}
