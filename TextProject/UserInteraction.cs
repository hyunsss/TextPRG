using System;
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

      switch (answer) {
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
        default :
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
    Pokemon1 poketmon;

    public void GetPoketmon(Pokemon1 poketmon)
    {
      this.poketmon = poketmon;
    }

    public void WelcomeCenter() {
      System.Console.WriteLine("포켓몬 센터에 오신것을 환영합니다!");
      System.Console.WriteLine("플레이어의 포켓몬 상태를 확인합니다. . . . .");
    }
  }

}