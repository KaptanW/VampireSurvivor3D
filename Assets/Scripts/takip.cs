using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class takip : MonoBehaviour
{
    public NavMeshAgent enemy;
     Transform target;
     [SerializeField]BaseCan BaseCan;
     
    // Start is called before the first frame update
    void Start()
    {
      enemy = GetComponent<NavMeshAgent>();
     
      
    }

    // Update is called once per frame
    void Update()
    {
        if(BaseCan.BaseAlive == true)
        {
          target= GameObject.FindWithTag("kule").transform;
        }
        
        
        follow();


    }

    void follow(){
      
      if(target != null)
      {enemy.SetDestination(target.position);
      
      }
      else{
        
      }

    }


}
