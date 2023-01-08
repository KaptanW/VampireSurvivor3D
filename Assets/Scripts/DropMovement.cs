using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropMovement : MonoBehaviour
{
    Transform Target;
    public float MinModifier= 7f;
    public float MaxModifier= 11f;

    Vector3 _velocity= Vector3.zero;
    bool _isFollowing = false;
    public float hiz = 0.04f;
    CharacterStats CharacterStats;
    public float exp;
    // Start is called before the first frame update
    void Start()
    {
        Target= GameObject.FindWithTag("asker").transform;
    }
    public void StartFollowing(){
        _isFollowing = true;
    }
    // Update is called once per frame
    void Update()
    {
        
          if (_isFollowing)
        {
            transform.position= Vector3.SmoothDamp(transform.position, Target.position, ref _velocity, Time.deltaTime/hiz* Random.Range(MinModifier, MaxModifier));
        }
    }

     private void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag=="magnet"){

            _isFollowing=true;
        }
        if(other.gameObject.tag == "asker"){
        Destroy(this.gameObject);
        if(other.gameObject.TryGetComponent<CharacterStats>(out CharacterStats sistem))
        {
            sistem.expsystem(exp);
            Debug.Log("burda sikinti yok");
        }

        
    }
   
}}
