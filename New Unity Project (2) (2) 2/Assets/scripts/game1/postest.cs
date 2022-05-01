using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;


public class postest : MonoBehaviour
{
    public static string token;
    
    // void Start()
    // {
    //      User user=new User("admin","admin");
    //     string json=JsonUtility.ToJson(user);
    //     StartCoroutine(UnityWebRequestPOSTTEST("http://219.251.52.245:9999/api/authenticate",json));
    // }

    // IEnumerator UnityWebRequestPOSTTEST(string URL,string json)
    // {

    //     using (UnityWebRequest request = UnityWebRequest.Post(URL, json))
    //     {
    //         byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(json);
    //         request.uploadHandler = new UploadHandlerRaw(jsonToSend);
    //         request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
    //         request.SetRequestHeader("Content-Type", "application/json");

    //         yield return request.SendWebRequest();

    //         if (request.isNetworkError || request.isHttpError)
    //         {
    //             Debug.Log(request.error);
    //         }
    //         else
    //         {
    //             t responseData = JsonUtility.FromJson<t>(request.downloadHandler.text);
    //             postest.token=responseData.token;
    //             Debug.Log(request.downloadHandler.text);
    //                             Debug.Log(responseData.token);

    //         }

    //     }


        
    // }
}

