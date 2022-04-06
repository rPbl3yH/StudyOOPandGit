using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : Building
{
    
    public override void SpeakToWorld()
    {
        Debug.Log("Мы сделали продукт на фабрике");
    }


    // Start is called before the first frame update
    void Start()
    {
        SpawnProduct();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
