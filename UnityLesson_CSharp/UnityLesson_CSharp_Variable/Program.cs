﻿using System;

namespace UnityLesson_CSharp_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Person
    {
        // 변수 선언 형태 : 타입(자료형) 변수이름(대소문자 구분함)    =
        // Person 클래스의 멤버 변수 (필드)
        // = 은 대입연산자, 우변의 값을 좌변에 대입
        int age = 50; // 정수형나이 // int : 4byte의 정수-2147483648-2147483647
        float height = 223.0f; // 실수형 키 // float : 4byte의 실수
        bool isResting = false; // 논리형 쉬고있는가? // bool : 1byte의 논리 (참, 거짓은 1bit로 판별 가능하지만, CPU의 데이터처리 최소단위가 1Byte이므로 그 이하 단위 처리는 불가능하다)
        char genderChar = 'a'; // 문자형 성별 문자 // char : 2byte 문자
        string name = "abocde"; // 문자열형 이름 // string : 문자갯수 * 2byte 문자열

        // bit(비트) = 한자리 이진수 (0과 1, 정보처리의 최소 단위)
        // byte(바이트) = 8 bit ( CPU의 데이터 처리 최소 단위)
        // 4byte = 4*8bit = 32bit
        // 4byte가 표현할수있는 수의 범위 2^(bit 수)
    }







}

    