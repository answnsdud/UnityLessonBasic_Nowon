using System;

namespace UnityLesson_CSharp_InstantiationExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();
            orc1.name = "상급오크";
            orc1.height = 240.2f;
            orc1.age = 140;
            orc1.weight = 200.0f;
            orc1.genderChar = '남';
            orc1.isResting = false;

            Orc orc2 = new Orc();
            orc2.name = "하급오크";
            orc2.height = 120.0f;
            orc2.age = 60;
            orc2.weight = 120.0f;
            orc2.genderChar = '여';
            orc2.isResting = true;

            if(orc1.isResting=true)
            {
                orc1.Jump();
                orc1.Smash();
            }
                 
        }
        public class Orc
        {
            public int age;
            public float height;
            public bool isResting;
            public char genderChar;
            public string name;
            public string weight;

        }
        public void Jump()
        {
            Console.WriteLine($"{orc1} 이 점프했다");
        }
        public void Smash()
        {
            Console.WriteLine($"{orc1} 이 휘둘렀다");
        }
    }
}
