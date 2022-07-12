using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalWaterReaction : MonoBehaviour
{
    public GameObject SodiumFire_2, PotassiumFire_2;
    public GameObject Sodium, Potassium;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

       public IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sodium_2")
        {
            Sodium.SetActive(false);
            SodiumFire_2.SetActive(true);

            yield return new WaitForSeconds(6);
            SodiumFire_2.SetActive(false);
        }

        else if (other.gameObject.tag == "Potassium_2")
        {
            Potassium.SetActive(false);
            PotassiumFire_2.SetActive(true);

            yield return new WaitForSeconds(6);
            PotassiumFire_2.SetActive(false);
        }
    }
}
