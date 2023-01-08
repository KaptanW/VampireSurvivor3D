using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zaman : MonoBehaviour
{
    // Start is called before the first frame update
    [Header ("Timer Settings")]
    public float currentTime;
    public bool countDown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime= countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        Debug.Log(currentTime.ToString("0"));
    }
}
