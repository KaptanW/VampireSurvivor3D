using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeniSpawner : MonoBehaviour
{
    public Wave[] Waves;

    private Wave currentWave;

    [SerializeField]
    private Transform[] Spawnpoints;

    private float timeBtwnSpawns;
    private int i =0;

    int dusmansayisi;


    private bool stopSpawning = false;

    // Start is called before the first frame update
    private void Awake() {
        currentWave = Waves[i];
        timeBtwnSpawns = currentWave.TimeBeforeThisWave;
    }  
    

    // Update is called once per frame
    void Update()
    {

        dusmansayisi = GameObject.FindGameObjectsWithTag("enemy").Length;
       
        if(stopSpawning)
        {
            return;
        }
        if(Time.time >= timeBtwnSpawns && dusmansayisi ==0)
        {
            SpawnWave();
            IncWave();
            timeBtwnSpawns = Time.time + currentWave.TimeBeforeThisWave;
        }
    }

    private void SpawnWave()
    {
        for (int i=0; i< currentWave.NumberToSpawn; i++)
        {
            int num = Random.Range(0, currentWave.EnemiesInWave.Length);
            int num2 = Random.Range(0, Spawnpoints.Length);

            Instantiate(currentWave.EnemiesInWave[num], Spawnpoints[num2].position, Spawnpoints[num2].rotation);
        }
    }
    
    private void IncWave()
    {
        if(i+1< Waves.Length)
        {
            i++;
            currentWave = Waves[i];

        }
        else
        {
            stopSpawning= true;
        }
    }
}
