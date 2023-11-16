using System;

namespace TextProject
{

    public interface IUseItem
    {
        void UseItem();
    }

    class Items 
    {


        
    }

    class Poketball : Items, IUseItem
    {
        private string name;

        public Poketball()
        {
            name = "포켓볼";
        }

        public void UseItem( ) {}
    }

    class SmallPotion : Items, IUseItem
    {
        public void UseItem( ) {}
    }

    class BigPotion : Items, IUseItem
    {
        public void UseItem( ) {}
    }

    class WeirdCandy : Items, IUseItem {



        public void UseItem() {}
    }




    /*
    이상한 사탕 : 포켓몬의 레벨을 1 올려준다
    포켓몬의 현재 레벨에서 남은 경험치 만큼을 올려준다. 
    */

    /*
    포켓몬 볼
    작은 체력 회복
    큰 체력 회복
    상태이상 제거
    */
}