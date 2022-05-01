using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Models;
using Proyecto26;
using UnityEditor;
using UnityEngine.Networking;
public class apitest : MonoBehaviour
{
     void Start()
    {
        StartCoroutine(UnityWebRequestGETTest());
    }

    IEnumerator UnityWebRequestGETTest()
    {
        // GET 방식
        string apikey = "발급받은 API키를 넣는다.";
        string url = "http://219.251.52.245:9999/level/all" ;

		// UnityWebRequest에 내장되있는 GET 메소드를 사용한다.
        UnityWebRequest www = UnityWebRequest.Get(url);

        yield return www.SendWebRequest();  // 응답이 올때까지 대기한다.

        if (www.error == null)  // 에러가 나지 않으면 동작.
        {
            Debug.Log(www.downloadHandler.text);
        }
        else
        {
            Debug.Log(www.error);
        }
    }
}
