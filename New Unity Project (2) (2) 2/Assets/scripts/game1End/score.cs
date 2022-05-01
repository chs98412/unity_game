using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using UnityEngine.Networking;
using System;


public class score : MonoBehaviour
{
    
  

    // Start is called before the first frame update
    void Start()
    {

        this.GetComponent<Text>().text = (maincharac.coinPoint ).ToString();

    }



    // Update is called once per frame
    void Update()
    {
       
    }


    public void gotoHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void gotoLoad()
    {
        SceneManager.LoadScene("loadingScene");
    }
}
