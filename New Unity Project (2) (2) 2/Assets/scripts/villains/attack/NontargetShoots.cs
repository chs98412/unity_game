using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NontargetShoots : MonoBehaviour,Shoot{
public float villainShootTimer = 0;  //타이머
    public float villainShootRate = 1;   //악당의 사격속도 이거 줄이면 빨라짐
    public GameObject villainbullet;     //악당의 투사체

public void shoot(GameObject b,Transform tr){
     villainShootTimer += Time.deltaTime;

        float angle;

        if (villainShootTimer > villainShootRate)
        {
            villainShootTimer = 0;
            GameObject go = Instantiate(b) as GameObject;
            go.transform.position = new Vector3(tr.position.x, tr.position.y, 0);

            angle = Random.Range(1, 361);

            go.transform.Rotate(0, 0, angle);

        }
}
}