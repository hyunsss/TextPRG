using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public enum FullType
    {
        None = 0,
        Glass = 1,
        Fire = 2,
        Water = 3,
        Wind = 4,
        Thunder = 5,
        Fight = 6,
        Espher = 7,
        Insect = 8
    }

    public abstract class Poketmon
    {
        
        List<Skill> MySkills = new List<Skill>();
        public FullType fulltype;
        public string Name;
        public string Roar;
        public int Hp;
        public int FullHp;
        public int Level;
        public int Damage;
        public int Critical;
        public bool Death = false;

        public static void GetEnumName(int Value)
        {
            int[] enumValues = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach (int enumValue in enumValues)
            {
                Console.WriteLine(Enum.GetName(typeof(FullType), enumValue));
            }
            Console.ReadKey();

        }
        
        public int GetLevel() { return Level; }
        public int LevelUP() 
        {           
            this.Level = +1;    
            return Level;
        }
        public int GetFullHP()
        {
            this.FullHp = this.Level * 5 + this.FullHp; // 되나?
            return FullHp;
        }
        public int GetDamage()
        {
            this.Damage = this.Level * 10;
            return Damage;
        }

        public void HasDie()
        {
            if(this.Hp <= 0)
            {
                this.Death = true;
                Console.WriteLine("포켓몬이 기절했습니다.");
            }
        }
        public void attacked_skill(Poketmon pokemon, Skill skill )
        {
            Console.WriteLine("{0} 의 {1} 공격!", pokemon.Name, skill.NameSkill);
            if (pokemon.fulltype == FullType.Fire)
            { if (this.fulltype == FullType.Water)
                {
                    Console.WriteLine("{0}에게 {1} 만큼 치명적인 피해!", pokemon.Name,skill.TypeDamage );
                    this.Hp -= skill.TypeDamage;
                }
            }
            if (pokemon.fulltype == FullType.Water)
            {
                if (this.fulltype == FullType.Thunder)
                {
                    Console.WriteLine("{0}에게 {1} 만큼 치명적인 피해!", pokemon.Name, skill.TypeDamage);
                    this.Hp -= skill.TypeDamage;
                }
            }
            if (pokemon.fulltype == FullType.Glass)
            {
                if (this.fulltype == FullType.Fire)
                {
                    Console.WriteLine("{0}에게 {1} 만큼 치명적인 피해!", pokemon.Name, skill.TypeDamage);
                    this.Hp -= skill.TypeDamage;
                }
            }
            if (pokemon.fulltype == FullType.Thunder)
            {
                if (this.fulltype == FullType.Fight)
                {
                    Console.WriteLine("{0}에게 {1} 만큼 치명적인 피해!", pokemon.Name, skill.TypeDamage);
                    this.Hp -= skill.TypeDamage;
                }
            }
            if (pokemon.fulltype == FullType.Espher)
            {
                if (this.fulltype == FullType.Thunder)
                {
                    Console.WriteLine("{0}에게 {1} 만큼 치명적인 피해!", pokemon.Name, skill.TypeDamage);
                    this.Hp -= skill.TypeDamage;
                }
            }
            if (pokemon.fulltype == FullType.Insect)
            {
                if (this.fulltype == FullType.Espher)
                {
                    Console.WriteLine("{0}에게 {1} 만큼 치명적인 피해!", pokemon.Name, skill.TypeDamage);
                    this.Hp -= skill.TypeDamage;
                }
            }

            else
            {
                Console.WriteLine("{0} 는/은 {1} 의 데미지를 받았다.", this.Name, skill.DamageSkill);
            }
            HasDie();
        }

        public void Attack_skill (Skill skill)
        {
            attacked_skill(this, skill);
        }

    }
    public class Pikachu : Poketmon
    {
        public Pikachu(FullType fulltype, string Name, string Roar, int Hp, int Level, bool Death)
        {
            fulltype = FullType.Thunder;
            Name = "피카츄";
            Roar = "피카피카";
            Hp = FullHp;
            Level = 1;
            Death = false;
        }
    }
    public class Fury_pikachu : Poketmon
    {
        public Fury_pikachu(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Thunder;
            Name = "분노한 피카츄";
            Roar = "우워어어";
            Hp = FullHp;
            Level = 10;
        }
    }
    public class Bulbasaur : Poketmon
    {
        public Bulbasaur(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Glass;
            Name = "이상해씨";
            Roar = "이상해~";
            Hp = FullHp;
            Level = 1;
        }
    }
    public class Ivysaur : Poketmon
    {
        public Ivysaur(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Glass;
            Name = "이상해풀";
            Roar = "풀풀~";
            Hp = FullHp;
            Level = 5;
        }
    }
    public class Venusaur : Poketmon
    {
        public Venusaur(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Glass;
            Name = "이상해꽃";
            Roar = "꽃꽃~";
            Hp = FullHp;
            Level = 7;
        }
    }
    public class Charmander : Poketmon
    {
        public Charmander(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Fire;
            Name = "파이리";
            Roar = "파이~리";
            Hp = FullHp;
            Level = 1;
        }
    }
    public class Charmeleon : Poketmon
    {
        public Charmeleon(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Fire;
            Name = "리자드";
            Roar = "리자~드";
            Hp = FullHp;
            Level = 5;
        }
    }
    public class Charizard : Poketmon
    {
        public Charizard(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Fire;
            Name = "리자몽";
            Roar = "리자~몽";
            Hp = FullHp;
            Level = 7;
        }
    }
    public class Squirtle : Poketmon
    {
        public Squirtle(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Water;
            Name = "꼬부기";
            Roar = "꼬북꼬북";
            Hp = FullHp;
            Level = 1;
        }
    }
    public class Wartortle : Poketmon
    {
        public Wartortle(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Water;
            Name = "어니부기";
            Roar = "어니어니";
            Hp = FullHp;
            Level = 5;
        }
    }
    public class Blastoise : Poketmon
    {
        public Blastoise(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            fulltype = FullType.Water;
            Name = "거북왕";
            Roar = "거북~왕";
            Hp = FullHp;
            Level = 7;
        }
    }
}
