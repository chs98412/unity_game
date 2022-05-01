using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class povillain : villains
{
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        setMove();
        setAttack(2);
    }

    // Update is called once per frame
    void Update()
    {
        moveBehavior();
        
        shootBehavior(b,transform);
        
    }
}
