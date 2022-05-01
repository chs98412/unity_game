using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;

[Serializable]
public class User{
    public User(string name,int coins,int level){
        this.username=name;
        this.coins=coins;
        this.level=level;
    }
    public long userId;
    public string username;
    public int coins;
    public int level;
}



public class loginButton : MonoBehaviour
{
    public static long userId;
    public static string username;
    public static int coins;
    public static int level;
public static int[,] monsters= new int[6,6]{{1,0,0,0,0,0},{1,1,0,0,0,0},{1,1,1,0,0,0},{1,2,3,1,1,1},{2,2,2,2,2,2},{3,3,3,3,3,3}};

    public InputField ID;
    public GameObject createAccpanel;

    int loginSuccess;
    int finish;
    float timer;
    float time ;


     void Start()
    {
        timer = 0;
        time = 1;
    }
    void Update()
    {
        if (finish == 1) timer += Time.deltaTime;

        if(timer>time)
            HomeScene();
    }
   

    public void Info()
    {
        
        User user=new User(ID.text,0,0);
        Debug.Log(user.level);
        string json=JsonUtility.ToJson(user);
        StartCoroutine(UnityWebRequestPOSTTEST("http://219.251.52.245:9999/api/signup",json));
        


    }

    public void HomeScene()
    {
        
        SceneManager.LoadScene("Home");
    }


    public void createAccPanel()
    {
        createAccpanel.SetActive(true);
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
                 SceneManager.LoadScene("main1");
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

                SceneManager.LoadScene("Home");

            }

        }


        
    }


}