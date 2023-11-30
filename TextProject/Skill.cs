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

    }
}