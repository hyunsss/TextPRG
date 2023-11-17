using System;

namespace TextProject
{

    public interface IUseItem
    {
        void UseItem();
    }

    class Items 
    {
        protected string name;
        protected int Prize;
        protected Player player;
        //protected Poketmon poketmon;

        public Items() {
            name = "";
            Prize = 0;
        }

        public void GetPlayer() {
            // TODO GetPlayer 
            // this.player = GetPlayer();
        }     

        public void GetPoketmon() {
            // TODO GetPoketmon
            // this.poketmon = GetPoketmon;
        }

        
    }

    class Poketball : Items, IUseItem
    {
        public Poketball()
        {
            name = "포켓볼";
            Prize = 300;
        }

        public void UseItem( ) {
            /*
            //일정 체력의 이하가 될 수록 잡힐 확률이 증가.
            

            //유저 포켓몬 인벤토리 리스트에 하나를 추가하기
            poketmon = GetPoketmon();
            ex) Poketmonlist.Add(poketmon);
            */

        }
    }

    class SmallPotion : Items, IUseItem
    {
        private int RecoveryHP;

        public SmallPotion() {
            RecoveryHP = 30;
        }
        public void UseItem( ) {
            /*
            player.Hp = RecoveryHP;
            */

        }
    }

    class BigPotion : Items, IUseItem
    {
        private int RecoveryHP;

        public BigPotion() {
            RecoveryHP = 50;
        }
        public void UseItem( ) {
            /*
            player.Hp = RecoveryHP;
            */
        }
    }

    class WeirdCandy : Items, IUseItem {
        public void UseItem() {
        /*
        이상한 사탕 : 포켓몬의 레벨을 1 올려준다
        포켓몬의 현재 레벨에서 남은 경험치 만큼을 올려준다. 
        */

        }
    }




   

    /*
    포켓몬 볼
    작은 체력 회복
    큰 체력 회복
    상태이상 제거
    */
}