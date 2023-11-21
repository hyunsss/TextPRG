using System;

namespace TextProject
{

    public interface IUseItem
    {
        void UseItem();
    }

    //TODO 플레이어가 아이템을 UseItem을 했을 경우 아이템을 제거하기

    public class Item
    {
        protected string name;
        protected int Prize;
        protected Player player;
        protected Pokemon1 poketmon;
        //protected Poketmon poketmon;
        public string GetName { get { return name; } }
        public int GetPrize { get { return Prize; } }
        public Item()
        {
            name = "";
            Prize = 0;
        }

        public void GetPlayer(Player User)
        {
            // TODO GetPlayer 
            this.player = User;
            // this.player = GetPlayer();
        }

        public void GetPoketmon(Pokemon1 pokemon1)
        {
            // TODO GetPoketmon
            this.poketmon = pokemon1;
            // this.poketmon = GetPoketmon;
        }


    }

    class Poketball : Item, IUseItem        //포켓 볼
    {
        public Poketball()
        {
            name = "포켓볼";
            Prize = 300;
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
    class Potions : Item, IUseItem
    {
        protected int RecoveryHP;

        public void UseItem()
        {
            Console.WriteLine(" 작은 회복 물약을 사용합니다 !! ");
            if (!poketmon.FallDown)
            {        //기절 상태가 아닐 때
                if (poketmon.hp + RecoveryHP > poketmon.fullHp)
                {    // 기본 체력에서 물약을 먹었을 때 최대체력을 넘기는 경우
                    poketmon.hp = poketmon.fullHp;
                }
                else if (poketmon.hp + RecoveryHP < poketmon.fullHp)
                {     // 최대 체력을 안넘기는 경우
                    poketmon.hp += RecoveryHP;
                }
            }
            System.Console.WriteLine("체력이 {0}이 되었습니다!!", poketmon.hp);
        }
    }
    class SmallPotion : Potions      //작은 회복 물약
    {
        public SmallPotion()
        {
            name = "작은 회복 포션";
            Prize = 500;
            RecoveryHP = 30;
        }
    }

    class BigPotion : Potions        //큰 회복 물약
    {
        public BigPotion()
        {
            name = "큰 회복 포션";
            Prize = 700;
            RecoveryHP = 50;
        }
    }
    class WeirdCandy : Item, IUseItem
        {     //이상한 사탕
            public void UseItem()
            {
                //
                poketmon.level++;           //1레벨 증가
                                            //아이템을 사용한 뒤 포켓몬의 레벨에 따라 진화여부를 결정하는 함수 호출하기
            }
        }


    public interface ItemProduct
    {
        Item CreateItem();
    }

    public class PotionFactory : ItemProduct
    {
        public Item CreateItem()
        {
            return new Potions();
        }
    }



}



/*
포켓몬 볼
작은 체력 회복
큰 체력 회복
상태이상 제거
*/
