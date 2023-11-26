using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public class Skill
    {
        public String NameSkill;
        public int DamageSkill;
        public int TypeDamage;
        public int pp;
        public int PpMax;
        public FullType skillType;
        public (int, int) learnLevel;
        public Poketmon poketmon;


        public Skill(String name_skill, FullType skillType, int TypeDamage, int damage_skill, int pp, int ppMax, (int, int) learnLevel)
        {
            this.NameSkill = name_skill;
            this.skillType = skillType;
            this.DamageSkill = damage_skill;
            this.TypeDamage = TypeDamage;
            this.pp = pp;
            this.PpMax = ppMax;
            this.learnLevel = learnLevel;
        }
        //    public Skill GetSkill(Poketmon pokemon, Skill skill)
        //{
        //    Console.WriteLine("배우고 싶은 스킬을 선택하세요");
        //    Console.WriteLine("------------------------------");

        //    if (pokemon.LevelUP() == 3)
        //    {
        //        _ = all_type_skill1;

        //        switch (pokemon.fulltype)
        //        {
        //            case FullType.Fire:
        //                _ = fire_type_skill;
        //                break;
        //            case FullType.Water:
        //                _ = water_type_skill;
        //                break;
        //            case FullType.Glass:
        //                _ = glass_type_skill1;
        //                break;
        //            case FullType.Thunder:
        //                _ = thunder_type_skill;
        //                break;
        //        }
        //    }
        //    else if (pokemon.LevelUP() == 6)
        //    {
        //        _ = all_type_skill2;

        //        switch (pokemon.fulltype)
        //        {
        //            case FullType.Fire:
        //                _ = fire_type_skill2;
        //                break;
        //            case FullType.Water:
        //                _ = water_type_skill2;
        //                break;
        //            case FullType.Glass:
        //                _ = glass_type_skill2;
        //                break;
        //            case FullType.Thunder:
        //                _ = thunder_type_skill2;
        //                break;
        //        }
        //    }
        //    else if (pokemon.LevelUP()  == 10)
        //    {
        //        _ = all_type_skill3;

        //        switch (pokemon.fulltype)
        //        {
        //            case FullType.Fire:
        //                _ = fire_type_skill3;
        //                break;
        //            case FullType.Water:
        //                _ = water_type_skill3;
        //                break;
        //            case FullType.Glass:
        //                _ = glass_type_skill3;
        //                break;
        //            case FullType.Thunder:
        //                _ = thunder_type_skill3;
        //                break;
        //        }
        //    }
        //}    

        //public Skill[] boss_type_skill = // 보스 타입 스킬
        //{
        //     new Skill("사이코키네시스",12,15,1,3),
        //     new Skill("사이코쇼크",11,15,1,5),
        //     new Skill("환상빔",13,17,1,2),
        //     new Skill("미래예지",19,20,1,3),
        //};


    }
}