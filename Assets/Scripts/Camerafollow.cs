using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    float camOffsetZ;
    void Start()
    {
        camOffsetZ= gameObject.transform.position.z - Player.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_cameraPos = new Vector3(Player.position.x, gameObject.transform.position.y, Player.position.z + camOffsetZ);
        gameObject.transform.position = m_cameraPos;
    }
}
