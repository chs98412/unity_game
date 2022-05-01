using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public  class MoveF : MonoBehaviour{
    public Move createMove(){
        return new randomMove();
    }

}