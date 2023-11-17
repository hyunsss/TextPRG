using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    internal class Pokemon
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
            Espher = 7
        }
       

        public string Name;
        public string Roar;
        public int Hp;
        public int FullHp;
        public int Level;
        public int Mp;
        public int FullMp;
        public int Damage;
        public int Value;
        public bool life = false;

        public Pokemon(string Name, string Roar, int Hp, int FullHp, int Level, int Mp, int FullMp, int Damage, int Value, bool life)
        {

            this.Name = Name;
            this.Roar = Roar;
            this.Hp = Hp;
            this.Level = Level;
            this.Mp = Mp;
            this.FullHp = FullHp;
            this.FullMp = FullMp;
            this.Damage = Damage;
            this.Value = Value;
            this.life = life;
            
        }
        public static void GetEnumName(int value)
        {
            int[] enumValues = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            foreach (int enumValue in enumValues)
            {
                Console.WriteLine(Enum.GetName(typeof(FullType), enumValue));
            }
            Console.ReadKey();
        }


        public void introduce()
        {
            Console.WriteLine(GetEnumName());
        }

    }
      class Bulbasaur : Pokemon
    {
        public Bulbasaur (string Name, string Roar, int Hp, int FullHp, int Level, int Mp, int FullMp, int Damage, int Value, bool life)
        {

           Name ="이상해씨";
           Roar = "이상해~";
           Hp = 30;
           Level = 1;
           FullHp = 30;
           Damage = 3;
           Value = Value;
           life = life;
        }

    }


}
