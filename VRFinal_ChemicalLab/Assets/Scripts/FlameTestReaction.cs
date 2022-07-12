using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameTestReaction : MonoBehaviour
{

    public GameObject LithiumFire, PotassiumFire, SodiumFire, CopperFire, CalciumFire, BariumFire;
    public int FireType;
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
        if (other.gameObject.tag == "Lithium_1")
        {
            //Debug.Log("Hit");
            FireType = 1;
        }
        else if (other.gameObject.tag == "Potassium_1")
        {
            FireType = 2;
        }
        else if (other.gameObject.tag == "Sodium_1")
        {
            FireType = 3;
        }
        else if (other.gameObject.tag == "Copper_1")
        {
            FireType = 4;
        }
        else if (other.gameObject.tag == "Calcium_1")
        {
            FireType = 5;
        }
        else if (other.gameObject.tag == "Barium_1")
        {
            FireType = 6;
        }

        //wire collide with bunsen fire
        if(other.gameObject.tag == "bunsenFire")
        {
            if (FireType == 1)
            {
                LithiumFire.SetActive(true);
                FireType = 0;
            }
            else if (FireType == 2)
            {
                PotassiumFire.SetActive(true);
                FireType = 0;
            }
            else if (FireType == 3)
            {
                SodiumFire.SetActive(true);
                FireType = 0;
            }
            else if (FireType == 4)
            {
                CopperFire.SetActive(true);
                FireType = 0;
            }
            else if (FireType == 5)
            {
                CalciumFire.SetActive(true);
                FireType = 0;
            }
            else if (FireType == 6)
            {
                BariumFire.SetActive(true);
                FireType = 0;
            }
        }
    }

}
