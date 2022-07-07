using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaActive : MonoBehaviour
{
    public ParticleSystem lavaPaticleSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pouring")
        {
            Debug.Log("Hit");
            lavaPaticleSystem.Play();
        }
    }
}
