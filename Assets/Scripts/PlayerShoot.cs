using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletSpawn;

    public float TimeBetweenShots = 0.333f;
    private float m_timeStamp = 0f;
    // Start is called before the first frame update
    void FixedUpdate() {
        
        if((Time.time >= m_timeStamp) && (Input.GetKey(KeyCode.Mouse0)))
        {
            Fire();
            m_timeStamp = Time.time + TimeBetweenShots;
        }
    
        
    }

    // Update is called once per frame
    void Fire()
    {
        var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;

        Destroy(bullet, 1f);
    }
}
