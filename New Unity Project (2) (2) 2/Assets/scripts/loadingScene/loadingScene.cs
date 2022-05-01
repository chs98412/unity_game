using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;

[Serializable]
public class monsterCount{

    public int villain1;
    public int villain2;
    public int villain3;
    public int villain4;
    public int villain5;
    public int villain6;

}

public class loadingScene : MonoBehaviour
{

   public static int finish=0;


    // Start is called before the first frame update
    void Start()
    {

        for( int i=0;i<6;i++){
            finish+=loginButton.monsters[loginButton.level,i];

        }
        
    if(loginButton.level<0)
    {
                                SceneManager.LoadScene("Home");

    }
    else{
                 SceneManager.LoadScene("Game1");

    }

    }




    // Update is called once per frame
    void Update()
    {
       // Debug.Log("끝났나??     "+finish);

       // if (finish == 1) enterGame();
    }
    public void countmon()
    {
       
        }

    public void Vec()
    {

       


    }


    public void enterGame()
    {
        SceneManager.LoadScene("Game1");
    }
}
