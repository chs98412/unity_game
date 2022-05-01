using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;

public class userinfo : MonoBehaviour
{
    // Start is called before the first frame update
    public Text coinDisplay;
    public static int coins;
public static int level;

[Serializable]
public class userinform{


    public string username;
    public string password;
    public string nickname;
    public int coins;
    public int level;
    public string authorityDtoSet;

}
    void Start()
    {
      StartCoroutine(UnityWebRequestGETTest());
    }
       IEnumerator UnityWebRequestGETTest()
    {
        // GET 방식
        string url = "http://219.251.52.245:9999/api/user/"+loginButton.username ;

		// UnityWebRequest에 내장되있는 GET 메소드를 사용한다.
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();  // 응답이 올때까지 대기한다.

        if (www.error == null)  // 에러가 나지 않으면 동작.
        {

            userinform responseData = JsonUtility.FromJson<userinform>(www.downloadHandler.text);
            coinDisplay.text=responseData.coins.ToString();
            userinfo.coins=responseData.coins;
            userinfo.level=responseData.level;
            Debug.Log(www.downloadHandler.text);

        }
        else
        {
            Debug.Log(www.error);
        }
    }
    // Update is called once per frame
   
}
