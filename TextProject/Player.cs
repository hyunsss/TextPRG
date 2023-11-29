using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public class Player
    {
        List<Poketmon> Mypoketmon = new List<Poketmon>();

        Poketmon mypo = new Pikachu();

        public void ChoicePoketmon(int choice)
        {
            this.MySkills[0] = skills[1];
            for (int i = 1; i <= 3; i++)
                this.MySkills[i] = skills[0];
            if (choice == 1)
            {
                Mypoketmon.Add(new Bulbasaur());
            }
            else if (choice == 2)
            {
                Mypoketmon.Add(new Charmander());

            }
            else if (choice == 3)
            {
                Mypoketmon.Add(new Squirtle());

            }
            else if (choice == 4)
            {
                Mypoketmon.Add(new Pikachu());
            }
        }
        public void Evolve()
        {
            PlayerPokemon poketmon = new PlayerPokemon();
            if (poketmon.LevelUP() == 3 && this.evol[0] == 1)
            {

                Console.WriteLine("오잉? {0}의 상태가?", this.Name);
                Thread.Sleep(500);
                Console.WriteLine("축하합니다!");
                Console.Write("당신의 {0}이/가", this.Name);
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
                Console.Write(" { 1}로 진화했습니다!", this.Name);
                Console.WriteLine($"{this.Roar}");
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
                Console.WriteLine($"{this.Roar}");
                this.evol[1] = 0;
            }
        }



    }
}
