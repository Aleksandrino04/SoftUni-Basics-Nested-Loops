using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //броя на журито 

            string input = Console.ReadLine();

            double presentationEv; //сборът на всички оценки на моментната презентация

            int presentationNum = 0; //броя на всички презентации;
            double evaluation = 0; //сбор от средните оценки за всяка от презентациите

            //четем имена презентации и ги оценяваме, докато не получим input = "finish"
            while (input != "Finish")
            {
                //=>input => име на презентация 

                presentationEv = 0;// нулираме сборът от оценките на всеки оценяващ

                for (int i = 1; i <= n; i++)
                {
                    //=> всеки ще даде оценка => ще се добавя към personalEvaluation
                    presentationEv += double.Parse(Console.ReadLine());
                }

                //намираме средна оценка => 
                presentationEv = presentationEv / n;

                // трябва да я добавим към сбора на всички средни оценки=> 
                evaluation += presentationEv;

                Console.WriteLine($"{input} - {presentationEv:f2}.");

                presentationNum++;

                //четем нов вход (input)
                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {evaluation / presentationNum:f2}.");
        }
    }
}


