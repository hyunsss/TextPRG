using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    internal class Gamemanager
    {
        string gameName = "Pokemon World";
          public bool isGameOver = false;
        Npc npc;
        ODoctor oDoctor;
        Nurse nurse;
        JangChungGymNpc jangChungGymNpc;
        GoyangGymNpc goyangGymNpc;
        SeoulGymNpc seoulGymNpc;
        Merchant merchant;
        public int gotoGymCount = 0;
      
     
        public void RunGame()
        {
            StartDisplay();
            StartOrExit();

        }
     void StartDisplay()
        {
            Console.Clear();
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine($"*                                Welcome to {gameName}                                    *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("*                                                                                            *");
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }

        void StartGame()
        {
            Console.Write("플레이어 이름을 입력해주세요: ");
            Player player = new Player(Console.ReadLine());
            Console.WriteLine($"플레이어 {player.name}님, 환영합니다! {gameName}에 입장합니다. ");
            Thread.Sleep(1500); // 1.5초 동안 프로그램을 멈춤
            Console.Clear();
        }

        void StartOrExit()
        {

            Console.WriteLine("                                     1. 게임시작");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                       2 나가기");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    StartGame();
                    break;

                case 2:
                    Console.WriteLine("게임을 종료합니다");
                    isGameOver = true;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("                           올바른 숫자를 다시 입력해주세요...");
                    Thread.Sleep(1500); // 1.5초 동안 프로그램을 멈춤
                    Console.Clear();
                    RunGame();

                    break;

            }
        }
        void ChoiceMyPokemon()
        {
            Console.WriteLine("함께 여행을 할 포켓몬을 선택해주세요.");
            //포켓몬 고르는 로직 구현
        }

        public void WhereToGO()
        {
            Console.WriteLine("어디로 갈지 선택해주세요.");
            Console.WriteLine("1. 체육관");
            Console.WriteLine("2. 포켓몬 센터");
            Console.WriteLine("3. 포켓몬 병원");
            Console.WriteLine("4. 상점");
            Console.WriteLine("5. 게임 종료");
            string playerInput = Console.ReadLine();
           
            if(int.TryParse(playerInput, out int choice))
            {
                switch (choice)
                {
                    case 1:
                   if(gotoGymCount == 0) 
                        {
                            jangChungGymNpc.NpcCommet();
                            gotoGymCount++;
                        }
                   else if(gotoGymCount == 1) 
                        {
                            goyangGymNpc.NpcCommet();
                            gotoGymCount++;
                        }
                   else
                        {
                            seoulGymNpc.NpcCommet();
                        }
                    break;

                    case 2:
                        oDoctor.NpcCommet();
                        break;

                    case 3:
                        nurse.NpcCommet();
                        break;
                        
                    case 4:
                        merchant.NpcCommet();
                        break;
                    default: 
                        Console.WriteLine("잘못 입력하셨습니다. 다시 입력해주세요.");
                        break;
                       
                }
            }
        }
    }
}
