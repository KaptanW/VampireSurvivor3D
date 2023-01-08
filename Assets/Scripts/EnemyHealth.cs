using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
     float maxHealth = 100f;
     float currentHealth;
     public GameObject exp,can;
    
    
    
     
    

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("anlik can: " + currentHealth);
         
    }

    

     public void TakeDamage(float damageAmount){
    
        currentHealth -= damageAmount;

        if (currentHealth <=0)
        {
            Death();


        }
    }

    void Death()
    {
        int num = Random.Range(0,5);
        Destroy(gameObject);
        if (num==0)
        {
            return;
        }
        else if (num==1)
        {
        Instantiate(exp, transform.position, Quaternion.identity);
        }
        else if(num==2)
        {
        Instantiate(can, transform.position, Quaternion.identity);
        }
    }
}