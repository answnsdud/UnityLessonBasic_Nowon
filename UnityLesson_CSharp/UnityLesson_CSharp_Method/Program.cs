
using System;

namespace UnityLesson_CSharp_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHelloworld();
            PrintSomething("asfq"); // 함수 호출에서 소괄호 안 내용은 매개변수(parameter)라고 한다.
            bool tmpIsFinished = false;
            tmpIsFinished = PrintSomethingAndReturnIsFinished("asgasgasg");
            Console.WriteLine(tmpIsFinished);
        }

        // 인자X, 반환X
        static void PrintHelloworld()
        {
            Console.WriteLine("Hello World!");
        }
        // 인자0 , 반환X
        static void PrintSomething(string something) // 함수 정의에서 소괄호 안 내용은 인자(Argument)라고 한다.

        {
            PrintHelloworld();
        }
        // 인자 0 , 반환 O
        // something을 콘솔창에 출력하고 true를 반환하는 함수
        static bool PrintSomethingAndReturnIsFinished(string something) // 

        {
            bool isFinished = false; // 지역 변수: 함수 내에서 정의된 변수 ( 이 함수 안에서만 연산을 위해 사용 )
            Console.WriteLine(something);
            isFinished = true;
            return isFinished;
        }

        // 인자O , 반환0


        /*반환형 함수이름(인자자료형 인자이름, 인자자료형 인자이름 ..)
        {

             함수 연산 내용

             return 반환할 내용
        }*/
    }
}







