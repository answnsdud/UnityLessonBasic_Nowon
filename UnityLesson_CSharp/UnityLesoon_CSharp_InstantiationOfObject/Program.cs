using System;

namespace UnityLesoon_CSharp_InstantiationOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // 점(.) 연산자 - 멤버에 접근하는 연산자
            person1.age = 40;
            person1.height = 223.41f;
            person1.isResting = true;
            person1.genderChar = '여';
            person1.name = "감아무개";
            // 객체의 멤버 함수 호출
            person1.SayAll_Info();

            
        }
    }
    public class Person
    {
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;
        public void SayAll_Info()
        {
            SayAge();
            SayHeight();
            IsResting();
            IenderChar();
            Name();
        }

        public void SayAge()
        {
            Console.WriteLine(age);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void IsResting()
        {
            Console.WriteLine(isResting);
        }
        public void IenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void Name()
        {
            Console.WriteLine(name);
        }
    }
    
}
