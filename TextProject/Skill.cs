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
        public static int Damage;
        Poketmon poketmon;


        public Skill(String name_skill, int TypeDamage, int damage_skill, int pp, int ppMax)
        {
            this.NameSkill = name_skill;
            this.DamageSkill = damage_skill;
            this.TypeDamage = TypeDamage;
            this.pp = pp;
            this.PpMax = ppMax;
            Damage = poketmon.GetDamage();
        }

        public void GetSkill(Poketmon pokemon, Skill skill)
        {
            if(pokemon.LevelUP() == 3)
            {
                Skill[] all_type_skill1; 

                if (pokemon.fulltype == FullType.Fire)
                {
                    _ = fire_type_skill;
                }
                else if (pokemon.fulltype == FullType.Water)
                {
                    Skill[] water_type_skill1;
                }
                else if (pokemon.fulltype == FullType.Glass)
                {
                    Skill[] glass_type_skill1;
                }
                else if (pokemon.fulltype == FullType.Thunder)
                {
                   _= thunder_type_skill;
                }
            }

            if(pokemon.LevelUP() > 3 && pokemon.LevelUP() < 6)
            {
                Console.WriteLine("배우고 싶은 스킬을 선택하세요");
                Console.WriteLine("------------------------------");
                Skill[] all_type_skill2;

                if (pokemon.fulltype == FullType.Fire)
                {
                    
                    Skill[] fire_type_skill1;
                }
                else if (pokemon.fulltype == FullType.Water)
                {
                    Skill[] water_type_skill2;
                }
                else if (pokemon.fulltype == FullType.Glass)
                {
                    Skill[] glass_type_skill2;
                }
                else if (pokemon.fulltype == FullType.Thunder)
                {
                    _ = thunder_type_skill2;
                }
                else if (pokemon.fulltype == FullType.Wind)
                {
                    Skill[] wind_type_skill1;
                }
                else if (pokemon.fulltype == FullType.Fight)
                {
                    Skill[] fight_type_skill2;
                }

            }

            if (pokemon.LevelUP() > 6 && pokemon.LevelUP() < 10)
            {
                Skill[] all_type_skill3;

                if (pokemon.fulltype == FullType.Fire)
                {
                    Skill[] fire_type_skill2;
                }
                else if (pokemon.fulltype == FullType.Water)
                {
                    Skill[] water_type_skill3;
                }
                else if (pokemon.fulltype == FullType.Glass)
                {
                    Skill[] glass_type_skill3;
                }
                else if (pokemon.fulltype == FullType.Thunder)
                {
                    _ = thunder_type_skill3;
                }
                else if (pokemon.fulltype == FullType.Wind)
                {
                    Skill[] wind_type_skill2;
                }
                else if (pokemon.fulltype == FullType.Fight)
                {
                    Skill[] fight_type_skill3;
                }
            }

        }
        static Skill[] Normal_skill =
        {
            new Skill("기본", Damage, Damage*2,1,100 )
        };

        static Skill[] fire_type_skill =
        {
            new Skill("불꽃세례",7,9,1,6),
            new Skill("용의숨결",7,9,1,6),
        };
        static Skill[] fire_type_skill2 =
        {
            new Skill("불꽃엄니",10,12,1,3),
            new Skill("화염방사",10,12,1,3),
            new Skill("화염자동차",12,15,1,3)
        };
        static Skill[] fire_type_skill3 =
        {
            new Skill("연옥",15,20,1,6),
            new Skill("플레어드라이브",20,25,1,3),
        };
/*
    레벨 낮을 때 : 
    레벨 중간 :

*/

        static Skill[] water_type_skill =
        {
            new Skill("물대포",7,9,1,5),
            new Skill("파도타기",7,9,1,6),
        };
        static Skill[] water_type_skill2 =
        {
            new Skill("거품광선",9,11,1,5),
            new Skill("아쿠아테일",8,10,1,5)
        };
        static Skill[] water_type_skill3 =
        {
            new Skill("하이드로펌프",12,15,1,3),
            new Skill("물의파동",12,15,1,3)
        };
        public Skill[] thunder_type_skill =
        {
             new Skill("일렉트로 러쉬",7,11,1,7),
            new Skill("에너지볼",7,11,1,5)
        };
        public Skill[] thunder_type_skill2 =
        {
            new Skill("번개",10,14,1,3),
            new Skill("전기쇼크",9,13,1,3),
        };
        public Skill[] thunder_type_skill3 =
        {
            new Skill("로케트박치기",13,17,1,3),
             new Skill("전기방출",13,17,1,4),
    };
        public Skill[] glass_type_skill1 =
        {
            new Skill("막치기",6,6,1,7),
            new Skill("씨폭탄",6,6,1,7),
            new Skill("덩쿨채찍",7,9,1,5),
        };
        public Skill[] glass_type_skill2 =
        {
            new Skill("잎날가르기",9,11,1,5),
            new Skill("메가드레인",9,11,1,5),
        };
        public Skill[] glass_type_skill3 =
        {
            new Skill("기가드레인",10,12,1,3),
            new Skill("솔라빔",15,20,1,6),
        };
        public Skill[] fight_type_skill2 =
        {
            new Skill("안다리걸기",7,9,1,6),
            new Skill("돌떨구기",9,11,1,5),
            };
            public Skill[] fight_type_skill3 =
        {
            new Skill("이판사판태클",12,14,1,4),
            new Skill("스톤샤워",12,15,1,3),
        };
        static Skill[] wind_type_skill1 =
        {
             new Skill("바람일으키기",7,9,1,6),
             new Skill("산들바람",7,10,1,6),
        };
        static Skill[] wind_type_skill2 =
        {
             new Skill("에어슬래시",13,17,1,2),
             new Skill("지구 던지기",13,17,1,2),
        };
        static Skill[] boss_type_skill =
        {
             new Skill("사이코키네시스",12,15,1,3),
             new Skill("사이코쇼크",11,15,1,5),
             new Skill("환상빔",13,17,1,2),
             new Skill("미래예지",19,20,1,3),
        };
        static Skill[] all_type_skill1 =
            {
            new Skill("몸통박치기",3,3,1,10),
            new Skill("할퀴기",5,5,1,10),
        };
        static Skill[] all_type_skill2 =
            {
            new Skill("물기",7,7,1,7),
            new Skill("독찌르기",7,9,1,6),
        };
        static Skill[] all_type_skill3 =
      {
            new Skill("독찌르기",9,11,1,5),
            new Skill("러스터캐논",13,17,1,2),
      
            };

}
}

