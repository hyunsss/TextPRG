using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    internal class Monster
    {
        public FullType Style { get; set; }
        public string Name;
        public string Roar;
        public int Hp;
        public int FullHp;
        public int Level;
        public int Damage;
        public bool Death = false;
        readonly Skill skill = new Skill();

        public Monster(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage)
        {
            this.Style = fullType;
            this.Name = Name;
            this.Roar = Roar;
            this.Hp = FullHp;
            this.FullHp = FullHp;
            this.Level = Level;
            this.Damage = Damage;
        }
        public void getcatch()
        {
            Console.WriteLine("{0}에게 포켓몬볼을 던졌다", Name);
            Console.WriteLine ("{0}이 울부짖으며 포켓몬볼에 들어갔다.{1}",Name, Roar);
            Console.WriteLine("포켓몬을 획득했습니다!!");
           // Player.getPokemon(); // 포켓몬 획득 기믹 내일 얘기해 보고 힘들거 같으면 빼도 ㄱㅊ
        }

        public void Monster_death(Monster monster)
        {
            Console.WriteLine("{0}를 쓰러트렸다!!", Name);
            Console.WriteLine("{0}.... 털썩", Roar);
            monster.Death = true;
        }
        public void Monster_skill(Skill skill)
        {
            Console.WriteLine("{0}의 {1} 스킬 공격!", Name,skill.NameSkill );
        }


        class Metapod : Monster
        {
            public Metapod(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage) : base(fullType, Name, Roar, FullHp, Level, Damage)
            {
                fullType = FullType.Insect;
                Name = "단데기";
                Roar = "....딱";
                FullHp = 70;
                Level = 3;
                Damage = 2;
            }
        }


        class Magikarp : Monster
        {
            public Magikarp(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage) : base(fullType, Name, Roar, FullHp, Level, Damage)
            {
                fullType = FullType.Wind;
                Name = "잉어킹";
                Roar = "잉잉~";
                FullHp = 20;
                Level = 2;
                Damage = 2;
            }

        }
        class Pidgey : Monster
        {
            public Pidgey(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage) : base(fullType, Name, Roar, FullHp, Level, Damage)
            {
                fullType = FullType.Wind;
                Name = "피죤";
                Roar = "피죤~";
                FullHp = 20;
                Level = 2;
                Damage = 2;
            }
        }
        class Raticate : Monster
        {
            public Raticate(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage) : base(fullType, Name, Roar, FullHp, Level, Damage)
            {
                fullType = FullType.Fight;
                Name = "레트라";
                Roar = "레트!";
                FullHp = 50;
                Level = 3;
                Damage = 6;
            }
        }

            class Machoke : Monster
        {
            public Machoke(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage) : base(fullType, Name, Roar, FullHp, Level, Damage)
            {
                fullType = FullType.Fight;
                Name = "근육몬";
                Roar = "근육~근육";
                FullHp = 70;
                Level = 5;
                Damage = 25;
            }
        }

        class Growlithe : Monster
        {
            public Growlithe(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage) : base(fullType, Name, Roar, FullHp, Level, Damage)
            {
                fullType = FullType.Fire;
                Name = "가디";
                Roar = "가디!";
                FullHp = 80;
                Level = 6;
                Damage = 35;
            }
        }
            class Dragonite : Monster
        {
            public Dragonite(FullType fullType, string Name, string Roar, int FullHp, int Level, int Damage) : base(fullType, Name, Roar, FullHp, Level, Damage)
            {
                fullType = FullType.Fire;
                Name = "망나뇽";
                Roar = "뇽~";
                FullHp = 100;
                Level = 7;
                Damage = 55;
            }
        }

    }
}
