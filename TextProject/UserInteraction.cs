using System;

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
      System.Console.WriteLine("플레이어 돈 : {0}", player.money);

      /*
      1. 작은 회복 포션

      2. 큰 회복 포션

      3. 포켓몬 볼

      4. 이상한 사탕

      TODO : CREATE Show Items UI 
      */
    }

  }


}