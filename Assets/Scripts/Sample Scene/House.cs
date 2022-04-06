using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : Building
{
    public override void SpeakToWorld()
    {
        Debug.Log("Мы родили ребенка!");
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
