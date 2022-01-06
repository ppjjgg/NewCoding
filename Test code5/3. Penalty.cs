using System;
using System.Collections.Generic;
using System.Text;

namespace Test_code5
{

    class Penalty
    {

        string[] performarray =
        {
          "[ 벌칙주 원샷 ]" ,
          "[ 1단계 러브샷 ]" ,
          "[ 2단계 러브샷 ]",
          "[ 엉덩이로 이름쓰기 ]",
          "[ 10초 동안 막춤추기 ]",
          "[ 발라드 1소절씩 부르기 ]",
          "[ 서로 안주 먹여주기 ]",
          "[ 진실 한 가지 대답하기 ]",
          "[ 서로 볼에 뽀뽀하기 ]",
          "[ 서로 손등에 뽀뽀하기 ]",

        };

        int[] deductionarray =
        {
           0,
           2,
           4,
           6,
           8,
          10,
          15,
          20,
          30,
          50,

        };


        public void penaltyrand()
        {
            Random rand = new Random();
            int randindex = rand.Next(0, performarray.Length);
            Console.WriteLine("이번 벌칙은 " + performarray[randindex] + " 입니다.");
            Console.WriteLine("남아 있는 체력에서 " + deductionarray[randindex] + " 포인트 차감됩니다.");
            Console.WriteLine("");


        }
    }
}
