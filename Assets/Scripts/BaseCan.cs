using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BaseCan : MonoBehaviour
{

     float MaxHealthbase = 100f;
     public float currentHealthbase;
     public bool BaseAlive;

    // Start is called before the first frame update
    void Start()
    {
        currentHealthbase = MaxHealthbase;
        BaseAlive = true;

    }

    // Update is called once per frame
    
     public void Damage(float DamageAmount){
        currentHealthbase -= DamageAmount;

        if(currentHealthbase <= 0){
            Death();
        }
    }

    void Death(){
        Destroy(this.gameObject);
        BaseAlive = false;
    }
    void Update(){
        
    }
}
