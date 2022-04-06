using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Gun
{
    [SerializeField] private float _fireWaitTime;
    [SerializeField] private int _bulletsInQueue = 3;

    public override void Shoot()
    {
        if(CurrentReloadTime <= 0)
        {
            StartCoroutine(SpawnBullets());
            CurrentReloadTime = ReloadTime;
        }
    }

    IEnumerator SpawnBullets()
    {
        for (int countBullet = 0; countBullet < _bulletsInQueue; countBullet++)
        {
            GameObject bullet = Instantiate(
                BulletPrefab,
                BulletSpawnPos.position,
                Quaternion.identity);
            yield return new WaitForSeconds(_fireWaitTime);
        }

    }
}
