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

    internal class Pokemon
    {
        public FullType Style { get; set; }
        public string Name;
        public string Roar;
        public int Hp;
        public int FullHp;
        public int Level;
        public int Damage;
        public bool Death = false;

        public Pokemon(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            this.Style = fulltype;
            this.Name = Name;
            this.Roar = Roar;
            this.Hp = Hp;
            this.Level = Level;
            this.FullHp = Level * 15;
            this.Damage = Level * 3;
        }
        public static void GetEnumName(int Value)
        {
            int[] enumValues = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach (int enumValue in enumValues)
            {
                Console.WriteLine(Enum.GetName(typeof(FullType), enumValue));
            }
            Console.ReadKey();

        }
        public void AddPokemons(FullType fulltype, string Name, string Roar, int Hp, int Level)
        {
            this.Style = fulltype;
            this.Name = Name;
            this.Roar = Roar;
            this.Hp = Hp;
            this.Level = Level;

        }

        public class Pikachu : Pokemon
        {
            public Pikachu(FullType fulltype, string Name, string Roar, int Hp, int Level, bool Death) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Thunder;
                Name = "피카츄";
                Roar = "피카피카";
                Hp = FullHp;
                Level = 1;
                Death = false;
            }
        }
        public class Fury_pikachu : Pokemon
        {
            public Fury_pikachu(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Thunder;
                Name = "분노한 피카츄";
                Roar = "우워어어";
                Hp = FullHp;
                Level = 10;
            }
        }
        public class Bulbasaur : Pokemon
        {
            public Bulbasaur(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Glass;
                Name = "이상해씨";
                Roar = "이상해~";
                Hp = FullHp;
                Level = 1;
            }
        }
        public class Ivysaur : Pokemon
        {
            public Ivysaur(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Glass;
                Name = "이상해풀";
                Roar = "풀풀~";
                Hp = FullHp;
                Level = 5;
            }
        }
        public class Venusaur : Pokemon
        {
            public Venusaur(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Glass;
                Name = "이상해꽃";
                Roar = "꽃꽃~";
                Hp = FullHp;
                Level = 7;
            }
        }
        public class Charmander : Pokemon
        {
            public Charmander(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Fire;
                Name = "파이리";
                Roar = "파이~리";
                Hp = FullHp;
                Level = 1;
            }
        }
        public class Charmeleon : Pokemon
        {
            public Charmeleon(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Fire;
                Name = "리자드";
                Roar = "리자~드";
                Hp = FullHp;
                Level = 5;
            }
        }
        public class Charizard : Pokemon
        {
            public Charizard(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Fire;
                Name = "리자몽";
                Roar = "리자~몽";
                Hp = FullHp;
                Level = 7;
            }
        }
        public class Squirtle : Pokemon
        {
            public Squirtle(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Water;
                Name = "꼬부기";
                Roar = "꼬북꼬북";
                Hp = FullHp;
                Level = 1;
            }
        }
        public class Wartortle : Pokemon
        {
            public Wartortle(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Water;
                Name = "어니부기";
                Roar = "어니어니";
                Hp = FullHp;
                Level = 5;
            }
        }
        public class Blastoise : Pokemon
        {
            public Blastoise(FullType fulltype, string Name, string Roar, int Hp, int Level) : base(fulltype, Name, Roar, Hp, Level)
            {
                fulltype = FullType.Water;
                Name = "거북왕";
                Roar = "거북~왕";
                Hp = FullHp;
                Level = 7;
            }
        }




    }
}
