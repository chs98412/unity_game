using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
//----------------

public class HomeManager : MonoBehaviour
{

    public GameObject HomePanel;
    [SerializeField]        //private 변수를 인스펙터 창에서 접근 가능하도록 함.
    GameObject GamePanel;
    [SerializeField]
    GameObject SettingPanel;
    [SerializeField]
    GameObject ShopPanel;
    [SerializeField]
    GameObject RankingPanel;
    [SerializeField]
    GameObject copyright;
    [SerializeField]
    GameObject credit;

    public AudioClip clip;

    GameObject lockbtn;

    public GameObject pang;

    public bool iscalc = true;


    //-----------------
    public static string namelist = "";
    public static string scorelist = "";
    //-----------------------

    // Start is called before the first frame update


    void Start()
    {



    //    SoundManager.instance.BGMplay("button", clip);
        HomePanel.SetActive(true);        //setActive는 인스펙터에 있는 체크 박스를 조정할 수 있게해줌
        GamePanel.SetActive(false);
        SettingPanel.SetActive(false);
        ShopPanel.SetActive(false);
        pang.SetActive(true);
        RankingPanel.SetActive(false);


    }

    //버튼 인스펙터의 onclick 이벤트에 homeManager스크립트를 추가해서 아래의 함수 연결시 버튼을 클릭하면 그 함수를
    //실행하도록 할 수 있다. 
    public void backtohome()
    {
     //   SoundManager.instance.BGMplay("button", clip);
        HomePanel.SetActive(true);
        GamePanel.SetActive(false);
        SettingPanel.SetActive(false);
        ShopPanel.SetActive(false);
        pang.SetActive(true);
        RankingPanel.SetActive(false);

        namelist = "";
        scorelist = "";
    }
    public void goGamePanel()
    {
    //    SoundManager.instance.BGMplay("button", clip);
        HomePanel.SetActive(false);
        GamePanel.SetActive(true);
        SettingPanel.SetActive(false);
        ShopPanel.SetActive(false);
        pang.SetActive(false);
        RankingPanel.SetActive(false);


    }

    public void goSettingPanel()
    {
      //  SoundManager.instance.BGMplay("button", clip);
        HomePanel.SetActive(false);
        GamePanel.SetActive(false);
        SettingPanel.SetActive(true);
        ShopPanel.SetActive(false);
        pang.SetActive(false);
        RankingPanel.SetActive(false);

    }
    public void showcopyright()
    {
      //  SoundManager.instance.BGMplay("button", clip);
        copyright.SetActive(true);
    }
    public void backsetting()
    {
     //   SoundManager.instance.BGMplay("button", clip);
        copyright.SetActive(false);
    }
    public void showcredit()
    {
   //     SoundManager.instance.BGMplay("button", clip);
        credit.SetActive(true);
    }
    public void creditbacksetting()
    {
      //  SoundManager.instance.BGMplay("button", clip);
        credit.SetActive(false);
    }
    public void goRankingPanel()
    {
    //    SoundManager.instance.BGMplay("button", clip);
        // HomePanel.SetActive(false);
        // GamePanel.SetActive(false);
        // SettingPanel.SetActive(false);
        // ShopPanel.SetActive(false);
        // pang.SetActive(true);
        // RankingPanel.SetActive(true);

StartCoroutine(UnityWebRequestGETTest());

      
    }
    public void goShopPanel()
    {
    //    SoundManager.instance.BGMplay("button", clip);
        HomePanel.SetActive(false);
        GamePanel.SetActive(false);
        SettingPanel.SetActive(false);
        ShopPanel.SetActive(true);
        pang.SetActive(true);
        RankingPanel.SetActive(false);


        //현재 아이디의 옷장을 보여줌.
        if (iscalc)
        {
            for (int i = 0; i < 5; i++)
            {
                Debug.Log(i);

                lockbtn = GameObject.Find("lock" + (i + 1));
                if (GameDirector.closet[i] == 1)
                {
                    lockbtn.SetActive(false);
                    iscalc = false;
                }
            }
        }

    }
    public void goShootingGame()
    {
    //    SoundManager.instance.BGMplay("button", clip);
        SceneManager.LoadScene("loadingScene");
    }

      IEnumerator UnityWebRequestGETTest()
    {
        // GET 방식
        string url = "http://219.251.52.245:9999/api/users/" ;

		// UnityWebRequest에 내장되있는 GET 메소드를 사용한다.
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();  // 응답이 올때까지 대기한다.
                Debug.Log("!!");

        if (www.error == null)  // 에러가 나지 않으면 동작.
        {

            List<User> responseData = JsonUtility.FromJson<List<User>>(www.downloadHandler.text);
            
            Debug.Log(www.downloadHandler.text);
            foreach(User i in responseData){
                Debug.Log(i.userId);
                Debug.Log(i.username);
                Debug.Log(i.coins);
                Debug.Log(i.level);

            }
            SceneManager.LoadScene("rankingScene");

        }
        else
        {
            Debug.Log(www.error);
                        SceneManager.LoadScene("Home");

        }
    }
}