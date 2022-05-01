using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pavillain : villains
{public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        setMove();
        setAttack(1);
    }

    // Update is called once per frame
    void Update()
    {
        moveBehavior();
        
        shootBehavior(b,transform);
        
    }
}
