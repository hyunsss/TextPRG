﻿using Microsoft.VisualBasic;
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

    }


}