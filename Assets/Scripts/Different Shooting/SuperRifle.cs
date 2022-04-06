using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperRifle : Gun
{
    public override void Shoot()
    {
        if (CurrentReloadTime <= 0)
        {
            for (int countBullet = -1; countBullet < 2; countBullet++)
            {
                GameObject bullet = Instantiate(
                    BulletPrefab,
                    BulletSpawnPos.position + new Vector3(countBullet, 0, 0),
                    Quaternion.identity);

            }
            CurrentReloadTime = ReloadTime;
        }
    }
}
