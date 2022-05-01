using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;



    [Serializable]
public class UserList
{
    public List<User> users;
}
public class rankinfo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    
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
          IEnumerator UnityWebRequestGETTest()
    {
        // GET 방식
        string url = "http://219.251.52.245:9999/api/users" ;

		// UnityWebRequest에 내장되있는 GET 메소드를 사용한다.
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();  // 응답이 올때까지 대기한다.

        if (www.error == null)  // 에러가 나지 않으면 동작.
        {
        Debug.Log("!!!");
            Debug.Log(www.downloadHandler.text);

            // List<User> responseData = JsonUtility.FromJson<List<User>>(www.downloadHandler.text);
            
            // Debug.Log(www.downloadHandler.text);
            // foreach(User i in responseData){
            //     Debug.Log(i.userId);
            //     Debug.Log(i.username);
            //     Debug.Log(i.coins);
            //     Debug.Log(i.level);

            // }
                        SceneManager.LoadScene("rankingScene");


        }
        else
        {
            Debug.Log(www.error);
                                    SceneManager.LoadScene("Home");

        }
    }
}
