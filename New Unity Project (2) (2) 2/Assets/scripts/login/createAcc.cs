using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class createAcc : MonoBehaviour
{
    public InputField nameInput;


    public InputField password1;
    public InputField password2;
    public InputField IDCreate;
    public GameObject passwordCK;
    public GameObject IDCk;
    public GameObject createAccpanel;


    class User
    {
        // 순위 정보를 담는 Rank 클래스
        // Firebase와 동일하게 name, score, timestamp를 가지게 해야함
        public string Name;
        public string PASSWORD;

        public string closet;
        public int pangpangColor;
        public int score;
        public int totalCoin;


        // JSON 형태로 바꿀 때, 프로퍼티는 지원이 안됨. 프로퍼티로 X

        public User(string Name, string PASSWORD, string closet, int pangpangColor, int score, int totalCoin)
        {
            // 초기화하기 쉽게 생성자 사용
            this.Name = Name;
            this.PASSWORD = PASSWORD;
            this.closet = closet;
            this.pangpangColor = pangpangColor;
            this.score = score;
            this.totalCoin = totalCoin;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        IDCheck();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Join()
    {

        if (password1.text == password2.text)
        {
            passwordCK.GetComponent<Text>().text = " ";
            IDCheck2();
        }
        else passwordCK.GetComponent<Text>().text = "달라";

    }

    public void IDCheck()
    {

      

    }

    public void IDCheck2()
    {
       
    }

    public void IDmessaging()
    {
        Debug.Log("중복");

        IDCk.GetComponent<Text>().text = "이미 존재하는 아이디입니다.";
        IDCk.SetActive(false);
        IDCk.SetActive(true);

    }
    public void IDcreated()
    {

        IDCk.GetComponent<Text>().text = "아이디 생성!";

    }


    public void CreateInfo()
    {
        
    }

    public void SetcreateAccPanel()
    {
        createAccpanel.SetActive(false);
    }

}
