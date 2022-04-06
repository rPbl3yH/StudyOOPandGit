using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Building
{
    public override void SpeakToWorld()
    {
        Debug.Log("Мы родили ребенка!");
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
