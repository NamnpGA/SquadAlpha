using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{

    private float countTime = 0;


    public override void Attack(Vector3 target)
    {
        if (countTime == 0)
        {
            GameObject obj = Instantiate(weaponObject.projectile);
            obj.transform.position = spawnPoint.position;
            Projectile bullet = obj.GetComponent<Projectile>();
            bullet.SetSpeed(weaponObject.projectileSpeed);
            bullet.MoveToTarget(target);
        }

        countTime += Time.deltaTime;
        if (countTime >= weaponObject.fireRate)
            countTime = 0;
    }
}
