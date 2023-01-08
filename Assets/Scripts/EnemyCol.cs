using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCol : MonoBehaviour
{
    public float damage = 1f;
    BaseCan BaseCan;


    private void OnTriggerEnter(Collider other) {
        
     
        if(other.gameObject)
        {
           //Debug.Log("cc");
        
            if(other.gameObject.TryGetComponent<BaseCan>(out BaseCan Can)){

            
           
            Can.Damage(damage);

        }
    }
}}
