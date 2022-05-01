using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test1 : MonoBehaviour
{
    class Rank
    {
        // 순위 정보를 담는 Rank 클래스
        // Firebase와 동일하게 name, score, timestamp를 가지게 해야함
        public string name;
        public int score;
        public int timestamp;
        // JSON 형태로 바꿀 때, 프로퍼티는 지원이 안됨. 프로퍼티로 X

        public Rank(string name, int score, int timestamp)
        {
            // 초기화하기 쉽게 생성자 사용
            this.name = name;
            this.score = score;
            this.timestamp = timestamp;
        }
    }


    void Start()
    {
       
        // 생성된 키의 자식으로 json데이터를 삽입
    }
}