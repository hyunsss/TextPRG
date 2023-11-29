using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
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
        public List<Skill> MySkills = new List<Skill>();
        public FullType fulltype;
        public string Name;
        public string Roar;
        public int Hp;
        public int FullHp;
        public int Level;
        public int Damage;
        public int Critical;
        public bool Death = false;
        public int[] evol = {1,1};
        public int[] myturn = { 1 };


        


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
            Evolve();
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
            if (this.Hp <= 0)
            {
                this.Death = true;
                Console.WriteLine("포켓몬이 기절했습니다.");
            }
        }
        public void attacked_skill(Poketmon pokemon, Skill skill)
        {
            Console.WriteLine("{0} 의 {1} 공격!", pokemon.Name, skill.NameSkill);
            if (pokemon.fulltype == FullType.Fire)
            {
                if (this.fulltype == FullType.Water)
                {
                    Console.WriteLine("{0}에게 {1} 만큼 치명적인 피해!", pokemon.Name, skill.TypeDamage);
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

        public void Attack_skill(Skill skill)
        {
            attacked_skill(this, skill);
        }
        public void LearnSkill(List<Skill> skills)
        {
            List<Skill> list = skills.FindAll((x) =>
            x.skillType == fulltype && x.learnLevel.Item1 < Level &&
                x.learnLevel.Item2 >= Level);

            if (list.Count == 0)
                return;

            Console.WriteLine("\n선택 가능한 스킬 목록");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {list[i].NameSkill}");
            }

            Console.WriteLine("입력");
            string str = Console.ReadLine();


            MySkills.Add(list[int.Parse(str) - 1]);
        }
        public void choicePok(int choice, List<Skill> skills)
        {
            this.MySkills[0] = skills[1];
            for (int i = 1; i <= 3; i++)
                this.MySkills[i] = skills[0];
            if (choice == 1)
            {
                Bulbasaur bulbasaur = new Bulbasaur();
                this.fulltype = bulbasaur.fulltype ;
                this.Name = bulbasaur.Name;
                this.Roar = bulbasaur.Roar;
                this.Hp = FullHp;
                this.Damage = bulbasaur.Damage;
                this.Level = 1;
            }
            else if (choice == 2)
            {
                Charmander charmander = new Charmander();
                this.fulltype = charmander.fulltype;
                this.Name = charmander.Name;
                this.Roar = charmander.Roar;
                this.Hp = charmander.Hp;
                this.FullHp = charmander.FullHp;
                this.Damage = charmander.Damage;
                this.Level = 1;

            }
            else if (choice == 3)
            {
                Squirtle squirtle = new Squirtle();
                this.fulltype = squirtle.fulltype;
                this.Name = squirtle.Name;
                this.Roar = squirtle.Roar;
                this.Hp = squirtle.Hp;
                this.FullHp = squirtle.FullHp;
                this.Damage = squirtle.Damage;
                this.Level = 1;

            }
            else if (choice == 4)
            {
                Pikachu pikachu = new Pikachu();
                this.fulltype = pikachu.fulltype;
                this.Name = pikachu.Name;
                this.Roar = pikachu.Roar;
                this.Hp = pikachu.Hp;
                this.FullHp = pikachu.FullHp;
                this.Damage = pikachu.Damage;
                this.Level = 1;
            }
        }
        public void Evolve()
        {
            PlayerPokemon poketmon = new PlayerPokemon();
            if (poketmon.LevelUP() == 3 && this.evol[0] == 1)
            {
                
                Console.WriteLine("오잉? {0}의 상태가?",this.Name );
                Thread.Sleep(500);
                Console.WriteLine("축하합니다!");
                Console.Write("당신의 {0}이/가" ,this.Name);
                Thread.Sleep(500);
                if (this.Name == "이상해씨")
                {
                    Ivysaur ivysaur = new Ivysaur();
                    this.fulltype = ivysaur.fulltype;
                    this.Name = ivysaur.Name;
                    this.Roar = ivysaur.Roar;
                    this.Hp = ivysaur.Hp;
                    this.FullHp = ivysaur.FullHp;

                }
                else if (this.Name == "파이리")
                {
                    Charmeleon charmeleon = new Charmeleon();
                    this.fulltype = charmeleon.fulltype;
                    this.Name = charmeleon.Name;
                    this.Roar = charmeleon.Roar;
                    this.Hp = charmeleon.Hp;
                    this.FullHp = charmeleon.FullHp;

                }
                else if (this.Name == "꼬부기")
                {
                    Wartortle wartortle = new Wartortle();
                    this.fulltype = wartortle.fulltype;
                    this.Name = wartortle.Name;
                    this.Roar = wartortle.Roar;
                    this.Hp = wartortle.Hp;
                    this.FullHp = wartortle.FullHp;

                }
                Console.Write(" { 1}로 진화했습니다!" ,this.Name);
                this.evol[0] = 0;

            }
            else if (LevelUP() == 6 && this.evol[1] == 1)
            {
                Console.WriteLine("오잉? {0}의 상태가?", this.Name);
                Thread.Sleep(500);
                Console.WriteLine("축하합니다!");
                Console.Write("당신의 {0}이/가", this.Name);
                Thread.Sleep(500);
                if (this.Name == "이상해풀")
                {
                    Venusaur venusaur = new Venusaur();
                    this.fulltype = venusaur.fulltype;
                    this.Name = venusaur.Name;
                    this.Roar = venusaur.Roar;
                    this.Hp = venusaur.Hp;
                    this.FullHp = venusaur.FullHp;
                }
                else if (this.Name == "리자드")
                {
                    Charizard Charizard = new Charizard();
                    this.fulltype = Charizard.fulltype;
                    this.Name = Charizard.Name;
                    this.Roar = Charizard.Roar;
                    this.Hp = Charizard.Hp;
                    this.FullHp = Charizard.FullHp;

                }
                else if (this.Name == "어니부기")
                {
                    Blastoise Blastoise = new Blastoise();
                    this.fulltype = Blastoise.fulltype;
                    this.Name = Blastoise.Name;
                    this.Roar = Blastoise.Roar;
                    this.Hp = Blastoise.Hp;
                    this.FullHp = Blastoise.FullHp;
                }
                else if (this.Name == "피카츄")
                {
                    Fury_pikachu pikachu = new Fury_pikachu();
                    this.Level = pikachu.Level;
                    this.fulltype = pikachu.fulltype;
                    this.Name = pikachu.Name;
                    this.Roar = pikachu.Roar;
                    this.Hp = pikachu.Hp;
                    this.FullHp = pikachu.FullHp;
                    Console.WriteLine("피카츄는 라이츄로 진화하여 2레벨이 더 올랐습니다!");
                }

                Console.WriteLine(" {1}로 진화했습니다!", Name);
                this.evol[1] = 0;
            }
        }
    }


}