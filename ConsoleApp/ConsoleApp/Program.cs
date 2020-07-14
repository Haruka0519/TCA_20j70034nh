using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string exheight = "";
            string exweight = "";
            for (int i = 0; i < args.Length; i++)
            {
                if (i == 0) exheight = args[i];
                if (i == 0) exweight = args[i];

            }

            float height = EX("身長を入力してください(m)");
            float weight = EX("体重を入力してください(kg)");
            float bmi = BMI(height, weight);

            Console.WriteLine("BMIは" + bmi + "です");
        }
        static float EX(string top, string log)
        {
            float PV = 0f;
            bool PS = float.TryParse(top, out PV);
           
            while (PS)
            {
                Console.WriteLine(log);
                string input = Console.ReadLine();
                PS = float.TryParse(input, out PV);

                if (PS)
                    Console.WriteLine("数値を入力してください");
            }
            return PV;
        }
        static float BMI(float height,float weight)
        {
            return weight / (height + height);
        }
    
    
    
    
    
    
    
    }
}
