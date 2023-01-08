using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellProperties : MonoBehaviour 
{
    WeaponData Weaponmanager;
    public WeaponStats stats;
    float damage;
    EnemyHealth EnemyHealth;



    void Start()
    {
        
        Debug.Log(stats.damage);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "enemy"){
          Destroy(this.gameObject);
        if(collision.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth Enemycomponent))
        {
            
            
            Enemycomponent.TakeDamage(stats.damage);
            
              }
            
        }}

         
    }

