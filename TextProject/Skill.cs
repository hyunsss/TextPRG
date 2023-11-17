using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    internal class Skill
    {
        String NameSkill;
        int DamageSkill;
        int TypeDamage;
        int pp;
        int PpMax;


        public Skill(String name_skill, int TypeDamage, int damage_skill, int pp, int ppMax)
        {
            this.NameSkill = name_skill;
            this.DamageSkill = damage_skill;
            this.TypeDamage = TypeDamage;
            this.pp = pp;
            this.PpMax = pp;
        }
        static Skill[] skills =
            {
            new Skill("",0,0,0,0),
            new Skill("몸통박치기",3,3,1,10),
            new Skill("할퀴기",5,5,1,10),
            new Skill("물기",7,7,1,7),
            new Skill("막치기",6,6,1,7),
            new Skill("불꽃세례",7,9,1,6),
            new Skill("용의숨결",12,15,1,3),
            new Skill("불꽃엄니",10,12,1,3),
            new Skill("베어가르기",10,12,1,4),
            new Skill("화염방사",10,12,1,3),
            new Skill("안다리걸기",7,9,1,6),
            new Skill("바람일으키기",7,9,1,6),
            new Skill("돌떨구기",9,11,1,5),
            new Skill("물의파동",12,15,1,3),
            new Skill("거품광선",9,11,1,5),
            new Skill("전기쇼크",12,15,1,3),
            new Skill("러스터캐논",13,17,1,2),
            new Skill("에어슬래시",13,17,1,2),
            new Skill("환상빔",13,17,1,2),
            new Skill("독찌르기",7,9,1,6),
            new Skill("파도타기",7,9,1,6),
            new Skill("사이코쇼크",9,11,1,5),
            new Skill("사이코키네시스",12,15,1,3),
            new Skill("화염자동차",12,15,1,3),
            new Skill("잎날가르기",9,11,1,5),
            new Skill("독찌르기",9,11,1,5),
            new Skill("스톤샤워",12,15,1,3),
            new Skill("하이드로펌프",12,15,1,3),
            new Skill("번개",12,15,1,3),
            new Skill("기가드레인",10,12,1,3),
            new Skill("미래예지",12,15,1,3),
            new Skill("플레어드라이브",20,25,1,3),
            new Skill("덩쿨채찍",7,9,1,5),
            new Skill("씨폭탄",6,6,1,7),
            new Skill("돌진",7,9,1,7),
            new Skill("메가드레인",9,11,1,5),
            new Skill("에너지볼",9,11,1,5),
            new Skill("이판사판태클",9,11,1,5),
            new Skill("솔라빔",15,20,1,6),
            new Skill("연옥",15,20,1,6),
            new Skill("물대포",7,9,1,5),
            new Skill("아쿠아테일",8,10,1,5),
            new Skill("로케트박치기",12,15,1,3)};
}
}

