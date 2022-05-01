using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class villains : MonoBehaviour{


public float villainMoveTimer = 0;  //타이머 (villainMoveRate까지 도달했는지 측정하는 시간) 건들 x
    public float villainMoveRate = 1;   //악당의 속도 이거 줄이면 빨라짐
    public float villanFootStep = 1;      //줄이면 보폭 줄어든다

    public float villainShootTimer = 0;  //타이머
    public float villainShootRate = 1;   //악당의 사격속도 이거 줄이면 빨라짐
    public GameObject villainbullet;     //악당의 투사체

    GameObject maincharac;

    public Image HP;

    public GameObject coin;
    public GameObject life;
    public Move move;
    public Shoot shoot;

    public MoveF mf ;
    public ShootF sf;


    //float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        mf = new MoveF();
        sf=new ShootF();
        maincharac = GameObject.Find("maincharac");
        HP.fillAmount = 1f;
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void moveBehavior(){
        move.move(transform);
    }
    public void shootBehavior(GameObject b,Transform tr){
        shoot.shoot(b,tr);
    }
    public void setMove(){
        mf = new MoveF();
        move=mf.createMove();
    }
    public void setAttack(int i){
        sf=new ShootF();
        shoot=sf.createShoot(i);
    }


    void OnTriggerEnter2D(Collider2D a)
    {
        if (a.gameObject.tag == "mainbullet")
        {
 item();
            Destroy(gameObject);
        }

    }

void item()
    {

        GameObject coinI = Instantiate(coin) as GameObject;
        coinI.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);


    }


}