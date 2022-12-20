using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingTest : MonoBehaviour
{

    string Name = "김호영";
    string address = "서울시 서대문구";
    string major = "패션디자인학과";

    //태어난 년도
    int num1 = 1997;
    //현재 년도
    public int num2 = 2022;
    //수업 일수
    int num3 = 123;
    //현재 진행 수업 일수
    public int num4 = 46;


    void Start()
    {
        //나의 나이
        int num5 = (num2 - num1 + 1);
        //남은 수업 일수
        int num6 = (num3 - num4);

        Debug.Log("안녕하세요");
        Debug.Log("저는 " + Name + " 입니다.");
        Debug.Log("저는 " + address + " 에 거주하고 있습니다.");
        Debug.Log("저의 전공은 " + major + " 입니다.");

        Debug.Log("저의 나이는 " + num5 + "세 입니다.");
        Debug.Log("3D AR/VR 컨텐츠 수업은 " + num3 + "일 진행됩니다.");
        Debug.Log($"현재 남은 수업 일수는 {num3-num4} 일 남았습니다.");

            }

    void Update()
    {
      

    }
}
