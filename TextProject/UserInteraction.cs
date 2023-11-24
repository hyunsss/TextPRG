using System;
using System.Formats.Asn1;
using System.Net;
using System.Security.Cryptography.X509Certificates;

/*
UserInteraction.cs 에서는 플레이어가 필요로하는 상호작용 센터를 정의합니다. 

1. Shop
2. Poketmon Center 


*/
namespace TextProject
{

  public class Shop
  {
    Player player;

    Shop(Player player)
    {
      this.player = player;
    }

    public void BuyRequest(Item item)
    {
      if (player.money < item.GetPrize)
      {
        System.Console.WriteLine("플레이어의 돈이 부족합니다");
        return;
      }

      System.Console.WriteLine("'{0}' 아이템을 구매하시겠습니까? ", item.GetName);
      System.Console.WriteLine("플레이어 돈 : {0}\t 아이템 값 : {1}", player.money, item.GetPrize);
      System.Console.WriteLine("구매 : Yes\t 취소 : No");
      string answer = Console.ReadLine();

      switch (answer)
      {
        case "y":
        case "Y":
        case "yes":
        case "Yes":
          System.Console.WriteLine("아이템을 구매합니다! ");

          player.money -= item.GetPrize;
          player.GetItem(item);
          break;
        case "n":
        case "N":
        case "No":
        case "no":
          System.Console.WriteLine("아이템 구매를 취소합니다.");
          break;
        default:
          System.Console.WriteLine("잘못된 입력을 하셨습니다. 다시 입력해주세요.");
          BuyRequest(item);
          break;
      }

    }

    public void ShowMenuItems()
    {
      System.Console.WriteLine("어서오세요! 포켓몬 상점입니다. 필요한 물건을 골라주세요");
      System.Console.WriteLine("플레이어 돈 : {0}\n", player.money);

      System.Console.WriteLine("1. 작은 회복 포션");
      string answer = Console.ReadLine();

      switch (answer)
      {
        case "1":
          Item smallpotion = new SmallPotion();
          BuyRequest(smallpotion);
          break;
        case "2":
          Item bigpotion = new BigPotion();
          BuyRequest(bigpotion);
          break;
        case "3":
          Item poketmonball = new Poketball();
          BuyRequest(poketmonball);
          break;
        case "4":
          Item weirdCandy = new WeirdCandy();
          BuyRequest(weirdCandy);
          break;
        case "T":
        case "t":
          ItemStatus();
          break;
        default:
          System.Console.WriteLine("잘못된 번호를 입력하셨습니다 다시 입력해주세요.");
          ShowMenuItems();
          break;
      }

      System.Console.WriteLine("구매를 원하면 번호를 입력해주세요. 아이템의 설명이 필요하면 T를 입력하면 됩니다!");
      System.Console.WriteLine("1. 작은 회복 포션   2. 큰 회복 포션   3. 포켓몬 볼   4. 이상한 사탕  T. 아이템 설명");
    }

    private void ItemStatus()
    {
      List<Item> ItemShopList = new List<Item>();
      ItemShopList.Add(new SmallPotion());
      ItemShopList.Add(new BigPotion());
      ItemShopList.Add(new Poketball());
      ItemShopList.Add(new WeirdCandy());

      foreach (Item item in ItemShopList)
      {
        System.Console.WriteLine("========  ITEM STATUS ========");
        System.Console.WriteLine("{0}의 세부정보를 표시합니다.", item.GetName);
        System.Console.WriteLine("가격 : {0}", item.GetPrize);
        System.Console.WriteLine("{0}\n", item.GetItemMessage);
      }

    }



  }

  public class PoketmonCenter
  {

    private void AllRecoveryPoketmon(List<Pokemon1> UserPoketmonList)
    {

      foreach (Pokemon1 UserPoketmon in UserPoketmonList)
      {
        //UserPoketmon.Hp = Userpoketmon.FullHp;
        System.Console.WriteLine("플레이어의 포켓몬 {0}이/가 완전히 회복되었습니다.,UserPoketmon.name");
      }
    }

    private void RecoveryPoketmon(Pokemon1 UserPoketmon)
    {
      UserPoketmon.hp = UserPoketmon.fullHp;
      System.Console.WriteLine("{0}의 체력을 완전히 회복시켰습니다!!", UserPoketmon);
    }

    public void WelcomeCenter(List<Pokemon1> UserPoketmonList)
    {
      
      int answer = 0;
      while (answer != 3)
      {
        answer = int.Parse(Console.ReadLine());
        System.Console.WriteLine("포켓몬 센터에 오신것을 환영합니다!");
        System.Console.WriteLine("플레이어의 포켓몬 상태를 확인합니다. . . . .\n");

        int A = 0, B = 0, C = 0, Perfect = 0;

        foreach (Pokemon1 UserPoketmon in UserPoketmonList)          //포켓몬 체력의 비율에 따른 등급판정
        {
          int PoketmonHpPercent = (UserPoketmon.hp / UserPoketmon.fullHp) * 100;

          if (PoketmonHpPercent <= 30)
          {
            C++;
          }
          else if (PoketmonHpPercent <= 80 && PoketmonHpPercent > 30)
          {
            B++;
          }
          else if (PoketmonHpPercent > 80 && PoketmonHpPercent < 100)
          {
            A++;
          }
          else if (PoketmonHpPercent == 100)
          {
            Perfect++;
          }
        }
        System.Console.WriteLine("현재 포켓몬 상태입니다.");
        System.Console.WriteLine("다친 곳 없음 : {0}, 경상 : {1}, 중상 : {2}, 큰 부상 : {3}\n", Perfect, A, B, C);  //현재 플레이어 포켓몬 리스트에서 체력 비율로 따진 포켓몬 들의 상태들을 카운트시킴

        foreach (Pokemon1 UserPoketmon in UserPoketmonList)   //플레이어에게 현재 포켓몬 상태를 전부 표시
        {
          int i = 1;
          System.Console.WriteLine("======= '순번 : {0}' =======", i);
          System.Console.WriteLine("포켓몬의 이름 : {0}", UserPoketmon.name);
          System.Console.WriteLine("현재 체력 : {0} / {1}\n", UserPoketmon.hp, UserPoketmon.fullHp);
          i++;
        }
        //플레이어 answer ?
        System.Console.WriteLine("포켓몬을 모두 회복시키겠습니까? :: 1번");
        System.Console.WriteLine("회복할 포켓몬을 선택할 수 있습니다. :: 2번");
        System.Console.WriteLine("포켓몬 센터 나가기 :: 3번");


        if (answer == 1)
        {
          AllRecoveryPoketmon(UserPoketmonList);  //포켓몬 전부 회복 함수 Private
        }
        else if (answer == 2) //포켓몬을 선택해서 회복 하고자 할 경우
        {
          int ChoicePoketmon = int.Parse(Console.ReadLine());
          if (ChoicePoketmon <= UserPoketmonList.Count) //입력한 번호가 리스트의 크기보다 넘지 않도록 예외처리
          {
            RecoveryPoketmon(UserPoketmonList[ChoicePoketmon - 1]); // 위에서 순번을 1부터 시작했기 때문에 -1을 해주어 올바른 인덱스 접근 유도
          }
          else
          {    //예외 처리 잘못된 값을 입력했다면 알려주기
            System.Console.WriteLine("플레이어의 포켓몬 리스트에 있는 포켓몬 번호보다 큰 값을 입력했습니다..");
          }
        }
        else if (answer == 3)
        {
          System.Console.WriteLine("포켓몬 센터를 나갑니다..");
          return;
        }
        else
        {
          System.Console.WriteLine("입력하신 번호가 맞지 않습니다.");
          continue;
        }
      }



    }

    //도감 기능 딕셔너리로 도감만들기



  }

}