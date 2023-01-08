using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    
    public GameObject enemytitip;
    
    public int enemyCount;
    

    void Start()
    {
        
            SpawnerSystem(enemyCount);
           

    }

    void SpawnerSystem(int enemynumber)
    {
        for (int i=0; i< enemynumber; i++)
        {
            GameObject dusman = Instantiate(enemytitip, new Vector3(Random.Range(0f,10f),0.5f,Random.Range(0f,10f)), Quaternion.identity);
        }
    }
}

