using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public  class ShootF : MonoBehaviour{
    public Shoot createShoot(int i){
        if (i==1)
        return new NontargetShoots();

        else
        return new TargetShoots();

    }

}