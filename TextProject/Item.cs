using System;
using System.Diagnostics.Contracts;

namespace TextProject
{

    public interface IUseItem
    {
        void UseItem();
    }

    //TODO 플레이어가 아이템을 UseItem을 했을 경우 아이템을 제거하기

    public class Item
    {
        protected string ItemMessage;
        protected string name;
        protected int Prize;
        protected Player player;
        protected Poketmon poketmon;
        public string GetName { get { return name; } }
        public int GetPrize { get { return Prize; } }
        public string GetItemMessage { get { return ItemMessage; } }
        public Item()
        {
            name = "";
            Prize = 0;
            ItemMessage = "아이테믄 아이템입니다.";
        }

        public void GetPlayer(Player User)
        {
            // TODO GetPlayer 
            this.player = User;
            // this.player = GetPlayer();
        }

        public void GetPoketmon(Poketmon pokemon1)
        {
            // TODO GetPoketmon
            this.poketmon = pokemon1;
            // this.poketmon = GetPoketmon;
        }

    }

    public class Poketball : Item, IUseItem        //포켓 볼
    {
        public Poketball()
        {
            name = "포켓볼";
            Prize = 300;
            ItemMessage = "아이템을 사용할 경우 일정 확률로 야생의 포켓몬을 인벤토리에 가져 올 수 있습니다.";
        }

        public void UseItem()
        {
            /*
            //일정 체력의 이하가 될 수록 잡힐 확률이 증가.
            

            //유저 포켓몬 인벤토리 리스트에 하나를 추가하기
            poketmon = GetPoketmon();
            ex) Poketmonlist.Add(poketmon);
            */

        }
    }

    public class SmallPotion : Item, IUseItem      //작은 회복 물약
    {
        private int RecoveryHP;
        public SmallPotion()
        {
            name = "작은 회복 포션";
            Prize = 500;
            RecoveryHP = 30;
            ItemMessage = "아이템을 사용하면 현재 포켓몬 체력에서 30을 회복할 수 있습니다. 아이템 회복은 최대체력을 넘기지 못합니다.";
        }
        public void UseItem()
        {
            Console.WriteLine(" 작은 회복 물약을 사용합니다 !! ");
            if (!poketmon.Death)
            {        //기절 상태가 아닐 때
                if (poketmon.Hp + RecoveryHP > poketmon.FullHp)
                {    // 기본 체력에서 물약을 먹었을 때 최대체력을 넘기는 경우
                    poketmon.Hp = poketmon.FullHp;
                }
                else if (poketmon.Hp + RecoveryHP < poketmon.FullHp)
                {     // 최대 체력을 안넘기는 경우
                    poketmon.Hp += RecoveryHP;
                }
            }
            System.Console.WriteLine("체력이 {0}이 되었습니다!!", poketmon.Hp);
        }
    }

    public class BigPotion : Item, IUseItem        //큰 회복 물약
    {
        private int RecoveryHP;

        public BigPotion()
        {
            name = "큰 회복 포션";
            Prize = 700;
            RecoveryHP = 50;
            ItemMessage = "아이템을 사용하면 현재 포켓몬 체력에서 50을 회복할 수 있습니다. 아이템 회복은 최대체력을 넘기지 못합니다.";
        }
        public void UseItem()
        {
            Console.WriteLine(" 작은 회복 물약을 사용합니다 !! ");
            if (!poketmon.Death)
            {        //기절 상태가 아닐 때
                if (poketmon.Hp + RecoveryHP > poketmon.FullHp)
                {    // 기본 체력에서 물약을 먹었을 때 최대체력을 넘기는 경우
                    poketmon.Hp = poketmon.FullHp;
                }
                else if (poketmon.Hp + RecoveryHP < poketmon.FullHp)
                {     // 최대 체력을 안넘기는 경우
                    poketmon.Hp += RecoveryHP;
                }
            }
            System.Console.WriteLine("체력이 {0}이 되었습니다!!", poketmon.Hp);
        }


    }
    public class WeirdCandy : Item, IUseItem
    {     //이상한 사탕
        public WeirdCandy() {
            ItemMessage = "아이템을 사용하면 포켓몬의 레벨업에 필요한 경험치를 얻을 수 있습니다!";
        }
        public void UseItem()
        {
            //
            poketmon.Level++;           //1레벨 증가
                                        //아이템을 사용한 뒤 포켓몬의 레벨에 따라 진화여부를 결정하는 함수 호출하기
        }
    }
}



/*
포켓몬 볼
작은 체력 회복
큰 체력 회복
상태이상 제거
*/
