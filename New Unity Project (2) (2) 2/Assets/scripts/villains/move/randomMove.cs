using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomMove : MonoBehaviour,Move{
public float villainMoveTimer = 0;  //타이머 (villainMoveRate까지 도달했는지 측정하는 시간) 건들 x
    public float villainMoveRate = 1;   //악당의 속도 이거 줄이면 빨라짐
    public float villanFootStep = 1;      //줄이면 보폭 줄어든다
public void move(Transform transform){
     villainMoveTimer += Time.deltaTime;
        if (villainMoveTimer > villainMoveRate)
        {
            villainMoveTimer = 0;
            int direc = Random.Range(1, 5);
            //            Debug.Log(direc);
            switch (direc)
            {
                case 1:
                    transform.Translate(villanFootStep, 0, 0);  //오른쪽 움직임 추후에 애니메이션 적용
                    break;

                case 2:
                    transform.Translate(-villanFootStep, 0, 0);  //왼쪽 움직임 추후에 애니메이션 적용
                    break;
                case 3:
                    transform.Translate(0, villanFootStep, 0);   //위쪽 움직임 추후에 애니메이션 적용
                    break;
                case 4:
                    transform.Translate(0, -villanFootStep, 0);  //아래쪽 움직임 추후에 애니메이션 적용
                    break;
            }

        }
}

}