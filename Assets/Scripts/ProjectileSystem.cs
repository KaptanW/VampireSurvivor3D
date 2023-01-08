using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSystem : WeaponBase
{
        //Atilcak olan projectile prefafi icinde collision olucak
    [SerializeField] GameObject knifePrefab;
    public Transform[] BulletSpawn;
    
    

    

    public override void Attack()
    {
        GameObject throwinKnife = (GameObject)Instantiate(knifePrefab, BulletSpawn[0].position, BulletSpawn[0].rotation);
        throwinKnife.GetComponent<Rigidbody>().velocity = throwinKnife.transform.forward * 50;
         Destroy(throwinKnife, 1f);
    }
}

