namespace TextProject
{
    internal class Dataclass
    {
        public void Data(string[] args)
        {
            PlayerPokemon plpo = new PlayerPokemon();

            List<Skill> skills = new List<Skill>();

            skills.Add(new Skill("기본", FullType.None, plpo.Damage, plpo.Damage * 2, 1, 100, (0, 1)));

            skills.Add(new Skill("불꽃세례", FullType.Fire, 7, 9, 1, 6, (1, 3))); // 불타입
            skills.Add(new Skill("용의숨결", FullType.Fire, 7, 9, 1, 6, (1, 3)));
            skills.Add(new Skill("불꽃엄니", FullType.Fire, 10, 12, 1, 3, (3, 6)));
            skills.Add(new Skill("화염방사", FullType.Fire, 10, 12, 1, 3, (3, 6)));
            skills.Add(new Skill("화염자동차", FullType.Fire, 12, 15, 1, 3, (3, 6)));
            skills.Add(new Skill("연옥", FullType.Fire, 15, 20, 1, 6, (6, 10)));
            skills.Add(new Skill("플레어드라이브", FullType.Fire, 20, 25, 1, 3, (6, 10)));

            skills.Add(new Skill("파도타기", FullType.Water, 7, 9, 1, 6, (1, 3)));// 물타입
            skills.Add(new Skill("물대포", FullType.Water, 7, 9, 1, 5, (3, 6)));
            skills.Add(new Skill("아쿠아테일", FullType.Water, 8, 10, 1, 5, (3, 6)));
            skills.Add(new Skill("거품광선", FullType.Water, 9, 11, 1, 5, (3, 6)));
            skills.Add(new Skill("물의파동", FullType.Water, 12, 15, 1, 3, (6, 10)));
            skills.Add(new Skill("하이드로펌프", FullType.Water, 12, 15, 1, 3, (6, 10)));

            skills.Add(new Skill("번개", FullType.Thunder, 10, 14, 1, 3, (3, 6)));// 전기타입
            skills.Add(new Skill("일렉트로 러쉬", FullType.Thunder, 7, 11, 1, 7, (1, 3)));
            skills.Add(new Skill("에너지볼", FullType.Thunder, 7, 11, 1, 5, (1, 3)));
            skills.Add(new Skill("전기쇼크", FullType.Thunder, 9, 13, 1, 3, (3, 6)));
            skills.Add(new Skill("로케트박치기", FullType.Thunder, 13, 17, 1, 3, (6, 10)));
            skills.Add(new Skill("전기방출", FullType.Thunder, 13, 17, 1, 4, (6, 10)));

            skills.Add(new Skill("막치기", FullType.Glass, 6, 6, 1, 7, (1, 3))); // 풀타입
            skills.Add(new Skill("씨폭탄", FullType.Glass, 6, 6, 1, 7, (1, 3)));
            skills.Add(new Skill("덩쿨채찍", FullType.Glass, 7, 9, 1, 5, (3, 6)));
            skills.Add(new Skill("잎날가르기", FullType.Glass, 9, 11, 1, 5, (3, 6)));
            skills.Add(new Skill("메가드레인", FullType.Glass, 9, 11, 1, 5, (3, 6)));
            skills.Add(new Skill("기가드레인", FullType.Glass, 10, 12, 1, 3, (6, 10)));
            skills.Add(new Skill("솔라빔", FullType.Glass, 15, 20, 1, 6, (6, 10)));

            skills.Add(new Skill("안다리걸기", FullType.Fight, 7, 9, 1, 6, (3, 6)));// 격투타입(여기부턴 동료 포켓몬으로 잡을때 생각해서 넣어둠)
            skills.Add(new Skill("돌떨구기", FullType.Fight, 9, 11, 1, 5, (3, 6)));
            skills.Add(new Skill("이판사판태클", FullType.Fight, 12, 14, 1, 4, (6, 10)));
            skills.Add(new Skill("스톤샤워", FullType.Fight, 12, 15, 1, 3, (6, 10)));

            skills.Add(new Skill("바람일으키기", FullType.Wind, 7, 9, 1, 6, (3, 6))); // 바람타입
            skills.Add(new Skill("산들바람", FullType.Wind, 7, 10, 1, 6, (3, 6)));
            skills.Add(new Skill("에어슬래시", FullType.Wind, 13, 17, 1, 2, (6, 10)));
            skills.Add(new Skill("지구 던지기", FullType.Wind, 13, 17, 1, 2, (6, 10)));

            skills.Add(new Skill("몸통박치기", FullType.None, 3, 3, 1, 10, (1, 3))); // 여기부턴 공통 스킬
            skills.Add(new Skill("할퀴기", FullType.None, 5, 5, 1, 10, (1, 3)));
            skills.Add(new Skill("물기", FullType.None, 7, 7, 1, 7, (3, 6)));
            skills.Add(new Skill("독찌르기", FullType.None, 7, 9, 1, 6, (3, 6)));
            skills.Add(new Skill("독찌르기", FullType.None, 9, 11, 1, 5, (6, 10)));
            skills.Add(new Skill("러스터캐논", FullType.None, 13, 17, 1, 2, (6, 10)));



            Console.WriteLine(plpo.Level);
            plpo.LearnSkill(skills);
            foreach (var t in plpo.MySkills)
            {
                Console.WriteLine($"{t.NameSkill}");
            }

            plpo.LevelUP();
            plpo.LearnSkill(skills);
            Console.Write($"\n레벨 : {plpo.Level}, 현재 스킬 목록 : ");
            foreach (var t in plpo.MySkills)
            {
                Console.Write($"{t.NameSkill}");
            }
            plpo.LevelUP();
            plpo.LearnSkill(skills);
            Console.Write($"\n레벨 : {plpo.Level}, 현재 스킬 목록 : ");
            foreach (var t in plpo.MySkills)
            {
                Console.Write($"{t.NameSkill}\t");
            }
            Console.WriteLine();

            plpo.LevelUP();
            plpo.LearnSkill(skills);
            Console.Write($"\n레벨 : {plpo.Level}, 현재 스킬 목록 : ");
            foreach (var t in plpo.MySkills)
            {
                Console.Write($"{t.NameSkill}");
            }
        }
        // 여기부터 포켓몬
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        public class PlayerPokemon : Poketmon
        {
            public PlayerPokemon()
            {
                fulltype = FullType.None;
                Name = "";
                Roar = "";
                Hp = FullHp;
                Level = 1;
                Death = false;
            }
        }

        public class Pikachu : PlayerPokemon
        {
            public Pikachu()
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
            public Fury_pikachu()
            {
                fulltype = FullType.Thunder;
                Name = "분노한 피카츄";
                Roar = "우워어어";
                Hp = FullHp;
                Level = 10;
            }
        }
        public class Bulbasaur : PlayerPokemon
        {
            public Bulbasaur()
            {
                fulltype = FullType.Glass;
                Name = "이상해씨";
                Roar = "이상해~";
                Hp = FullHp;
                Level = 1;
            }
        }
        public class Ivysaur : PlayerPokemon
        {
            public Ivysaur()
            {
                fulltype = FullType.Glass;
                Name = "이상해풀";
                Roar = "풀풀~";
                Hp = FullHp;
                Level = 5;
            }
        }
        public class Venusaur : PlayerPokemon
        {
            public Venusaur()
            {
                fulltype = FullType.Glass;
                Name = "이상해꽃";
                Roar = "꽃꽃~";
                Hp = FullHp;
                Level = 7;
            }
        }
        public class Charmander : PlayerPokemon
        {
            public Charmander()
            {
                fulltype = FullType.Fire;
                Name = "파이리";
                Roar = "파이~리";
                Hp = FullHp;
                Level = 1;
            }
        }
        public class Charmeleon : PlayerPokemon
        {
            public Charmeleon()
            {
                fulltype = FullType.Fire;
                Name = "리자드";
                Roar = "리자~드";
                Hp = FullHp;
                Level = 5;
            }
        }
        public class Charizard : PlayerPokemon
        {
            public Charizard()
            {
                fulltype = FullType.Fire;
                Name = "리자몽";
                Roar = "리자~몽";
                Hp = FullHp;
                Level = 7;
            }
        }
        public class Squirtle : PlayerPokemon
        {
            public Squirtle()
            {
                fulltype = FullType.Water;
                Name = "꼬부기";
                Roar = "꼬북꼬북";
                Hp = FullHp;
                Level = 1;
            }
        }
        public class Wartortle : PlayerPokemon
        {
            public Wartortle()
            {
                fulltype = FullType.Water;
                Name = "어니부기";
                Roar = "어니어니";
                Hp = FullHp;
                Level = 5;
            }
        }
        public class Blastoise : PlayerPokemon
        {
            public Blastoise()
            {
                fulltype = FullType.Water;
                Name = "거북왕";
                Roar = "거북~왕";
                Hp = FullHp;
                Level = 7;
            }
        }
        //여기부터 몬스터
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------
        class Metapod : Monster
        {
            public Metapod()
            {
                fulltype = FullType.Insect;
                Name = "단데기";
                Roar = "....딱";
                FullHp = 70;
                Level = 3;
            }
        }


        class Magikarp : Monster
        {
            public Magikarp()
            {
                fulltype = FullType.Wind;
                Name = "잉어킹";
                Roar = "잉잉~";
                FullHp = 20;
                Level = 2;
            }

        }
        class Pidgey : Monster
        {
            public Pidgey()
            {
                fulltype = FullType.Wind;
                Name = "피죤";
                Roar = "피죤~";
                FullHp = 20;
                Level = 2;
            }
        }
        class Raticate : Monster
        {
            public Raticate()
            {
                fulltype = FullType.Fight;
                Name = "레트라";
                Roar = "레트!";
                FullHp = 50;
                Level = 3;
            }
        }

        class Machoke : Monster
        {
            public Machoke()
            {
                fulltype = FullType.Fight;
                Name = "근육몬";
                Roar = "근육~근육";
                FullHp = 70;
                Level = 5;
            }
        }

        class Growlithe : Monster
        {
            public Growlithe()
            {
                fulltype = FullType.Fire;
                Name = "가디";
                Roar = "가디!";
                FullHp = 80;
                Level = 6;
            }
        }
        class Dragonite : Monster
        {
            public Dragonite()
            {
                fulltype = FullType.Fire;
                Name = "망나뇽";
                Roar = "뇽~";
                FullHp = 100;
                Level = 7;
            }
        }
    }