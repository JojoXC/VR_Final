using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBoxButton : MonoBehaviour
{
    ParticleSystem lavaParticleSystem;

    // Start is called before the first frame update
    void Start()
    {
        lavaParticleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LavaOut()
    {
        lavaParticleSystem.Play();
    }
}
