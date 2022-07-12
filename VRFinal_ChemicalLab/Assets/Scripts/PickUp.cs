using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject Sodium1, Sodium2, Potassium1, Potassium2;

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
        if (other.gameObject.tag == "Sodium_2")
        {
            Sodium1.SetActive(false);
            Sodium2.SetActive(true);
        }

        if (other.gameObject.tag == "Potassium_2")
        {
            Potassium1.SetActive(false);
            Potassium2.SetActive(true);
        }
    }

}
