using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeniShooter : MonoBehaviour
{
    [SerializeField] WeaponData BulletPrefab;
    [SerializeField] WeaponStats stats;
     
     
    public int Seviye;
    public CharacterStats xp;
    public float hasar;
    
    [SerializeField]
    public Transform[] BulletSpawn;

    public float TimeBetweenShots = 0.333f;
    private float m_timeStamp;
    // Start is called before the first frame update
    void FixedUpdate() {
        
        if(Time.time >= m_timeStamp) //&& (Input.GetKey(KeyCode.Mouse0)))
        {
            Fire();
            m_timeStamp = Time.time + stats.timeToAttack;
        }

    
        
    }
    
    public void Start(){
        
        
    }
 
    void Fire()
    {
        if(xp.seviye >=1){
        var bullet = (GameObject)Instantiate(BulletPrefab.weaponBaseprefab, BulletSpawn[0].position, BulletSpawn[0].rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
         Destroy(bullet, 1f);
        }

        if(xp.seviye >=2){
        var bullet = (GameObject)Instantiate(BulletPrefab.weaponBaseprefab, BulletSpawn[1].position, BulletSpawn[1].rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
         Destroy(bullet, 1f);
        }
        if(xp.seviye >=3){
        var bullet = (GameObject)Instantiate(BulletPrefab.weaponBaseprefab, BulletSpawn[2].position, BulletSpawn[2].rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
         Destroy(bullet, 1f);
        }
        if(xp.seviye >=4){
        var bullet = (GameObject)Instantiate(BulletPrefab.weaponBaseprefab, BulletSpawn[3].position, BulletSpawn[3].rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
         Destroy(bullet, 1f);
        }
        if(xp.seviye >=5){
        var bullet = (GameObject)Instantiate(BulletPrefab.weaponBaseprefab, BulletSpawn[4].position, BulletSpawn[4].rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
         Destroy(bullet, 1f);
        }

        
        

       
    }
}

