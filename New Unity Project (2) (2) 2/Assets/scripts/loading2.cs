using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.SceneManagement;

public class loading2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
               loginButton.coins+=maincharac.coinPoint;
       loginButton.level+=1;

        User user=new User(loginButton.username,loginButton.coins,loginButton.level);
        user.userId=loginButton.userId;
        string json=JsonUtility.ToJson(user);

StartCoroutine(UnityWebRequestPOSTTEST("http://219.251.52.245:9999/api/update",json));       

    }
IEnumerator UnityWebRequestPOSTTEST(string URL,string json)
    {

        using (UnityWebRequest request = UnityWebRequest.Post(URL, json))
        {
            byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(json);
            request.uploadHandler = new UploadHandlerRaw(jsonToSend);
            request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
                        SceneManager.LoadScene("Game1End");

            }
            else
            {
                User responseData = JsonUtility.FromJson<User>(request.downloadHandler.text);
                loginButton.userId=responseData.userId;
                loginButton.username=responseData.username;
                loginButton.coins=responseData.coins;
                loginButton.level=responseData.level;


                Debug.Log(request.downloadHandler.text);
                Debug.Log(loginButton.userId);
                Debug.Log(loginButton.username);
                Debug.Log(loginButton.coins);
                Debug.Log(loginButton.level);

        SceneManager.LoadScene("Game1End");

            }

        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
