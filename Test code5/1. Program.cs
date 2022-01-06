using System;

namespace Test_code5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("두근두근 왕게임 참가자 소개를 하겠습니다.");
            //Console.WriteLine("");


            //string[] namearray =
            //{
            //    "홍지은",
            //    "정현지",
            //    "박준규"
            //};


            //Gamer name1 = new Gamer();
            //name1.name = namearray[0];
            //Console.WriteLine("첫번째 참가자는 " + name1.name + " 입니다.");

            //Gamer name2 = new Gamer();
            //name2.name = namearray[1];
            //Console.WriteLine("두번째 참가자는 " + name2.name + " 입니다.");

            //Gamer name3 = new Gamer();
            //name3.name = namearray[2];
            //Console.WriteLine("세번째 참가자는 " + name3.name + " 입니다.");
            //Console.WriteLine("");



            //int[] hparray =
            //{
            //    50 ,
            //    45 ,
            //    40
            //};


            //Gamer hp1 = new Gamer();
            //hp1.hp = hparray[0];
            //Console.WriteLine("첫번째 참가자의 체력은 " + hp1.hp + " 포인트 입니다.");

            //Gamer hp2 = new Gamer();
            //hp2.hp = hparray[1];
            //Console.WriteLine("두번째 참가자의 체력은 " + hp2.hp + " 포인트 입니다.");

            //Gamer hp3 = new Gamer();
            //hp3.hp = hparray[2];
            //Console.WriteLine("세번째 참가자의 체력은 " + hp3.hp + " 포인트 입니다.");
            //Console.WriteLine("");






            Gamer gamerinfor = new Gamer();
            
            gamerinfor.creatname();
            Console.WriteLine("");

            gamerinfor.starthp();
            Console.WriteLine("");




            Penalty penalty0 = new Penalty();

            for (int t = 0; t < 10; t++)
            {
                penalty0.penaltyrand();

            }
            Console.WriteLine("");


        }
    }
}
