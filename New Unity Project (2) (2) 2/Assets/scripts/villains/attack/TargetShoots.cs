using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetShoots : MonoBehaviour,Shoot{
public float villainShootTimer = 0;  //타이머
    public float villainShootRate = 1;   //악당의 사격속도 이거 줄이면 빨라짐
    public GameObject maincharac;     //악당의 투사체

public void shoot(GameObject b,Transform tr){
     villainShootTimer += Time.deltaTime;
    maincharac=GameObject.Find("maincharac");
        float x;
        float y;
        float angle;

        if (villainShootTimer > 2)
        {


            villainShootTimer = 0;
            GameObject go = Instantiate(b) as GameObject;
            go.transform.position = new Vector3(tr.position.x, tr.position.y, 0);


            x = tr.position.x - maincharac.transform.position.x;
            y = tr.position.y - maincharac.transform.position.y;

            angle = Mathf.Atan2(Mathf.Abs(y), Mathf.Abs(x)) * Mathf.Rad2Deg;

            if (x < 0 && y < 0)
                go.transform.Rotate(0, 0, angle);

            else if (x > 0 && y < 0)
                go.transform.Rotate(0, 0, 180 - angle);
            else if (x < 0 && y > 0)
                go.transform.Rotate(0, 0, -angle);

            else
                go.transform.Rotate(0, 0, 180 + angle);


        }
}
}