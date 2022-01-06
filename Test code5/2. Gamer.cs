using System;
using System.Collections.Generic;
using System.Text;

namespace Test_code5
{

    public class Gamer
    {

        public string name;
        public int hp;


        public void creatname()
        {
            string[] namearray =
            {
                "홍지은",
                "정현지",
                "박준규"
            };

            Gamer name1 = new Gamer();
            name1.name = namearray[0];
            Console.WriteLine("첫번째 참가자는 " + name1.name + " 입니다.");

            Gamer name2 = new Gamer();
            name2.name = namearray[1];
            Console.WriteLine("두번째 참가자는 " + name2.name + " 입니다.");

            Gamer name3 = new Gamer();
            name3.name = namearray[2];
            Console.WriteLine("세번째 참가자는 " + name3.name + " 입니다.");

        }



        public void starthp()
        {
            int[] hparray =
            {
                50 ,
                45 ,
                40
            };


            Gamer hp1 = new Gamer();
            hp1.hp = hparray[0];
            Console.WriteLine("첫번째 참가자의 체력은 " + hp1.hp + " 포인트 입니다.");

            Gamer hp2 = new Gamer();
            hp2.hp = hparray[1];
            Console.WriteLine("두번째 참가자의 체력은 " + hp2.hp + " 포인트 입니다.");

            Gamer hp3 = new Gamer();
            hp3.hp = hparray[2];
            Console.WriteLine("세번째 참가자의 체력은 " + hp3.hp + " 포인트 입니다.");


        }


    }

}

