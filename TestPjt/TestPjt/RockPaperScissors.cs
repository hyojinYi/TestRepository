﻿using System;

namespace TestPjt
{
    class RockPaperScissors
    {
        static void Main()
        {
            int iRandom = 0;
            int iSelection = 0;
            string[] choice = { "가위", "바위", "보" };

            iRandom = (new Random()).Next(1, 4);

            Console.Write("1(가위, 2(바위), 3(보) 입력 : _\b");
            iSelection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n 사용자 : {choice[iSelection -1]}");
            Console.WriteLine($" 컴퓨터 : {choice[iRandom -1]}\n");

            if (iSelection == iRandom)
            {
                Console.WriteLine("비김");
            }
            else
            {
                switch (iSelection)
                {
                    case 1: Console.WriteLine((iRandom == 3) ? "승" : "패"); break ;
                    case 2: Console.WriteLine((iRandom == 2) ? "승" : "패"); break;
                    case 3: Console.WriteLine((iRandom == 1) ? "승" : "패"); break;
                }
            }

        }
    }
}
