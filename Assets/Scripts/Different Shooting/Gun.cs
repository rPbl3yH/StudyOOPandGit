using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected float ReloadTime;
    protected float CurrentReloadTime;

    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected Transform BulletSpawnPos;


    void Update()
    {
        if(CurrentReloadTime > 0)
        {
            CurrentReloadTime -= Time.deltaTime;
        }
    }

    public virtual void Shoot()
    {
        if(CurrentReloadTime <= 0)
        {
            GameObject bullet = Instantiate(
                BulletPrefab,
                BulletSpawnPos.position,
                Quaternion.identity);
            CurrentReloadTime = ReloadTime;
        }

    }
}
