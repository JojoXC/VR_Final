using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNext : MonoBehaviour
{

    public GameObject buttonText, buttonNextText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextText()
    {
        if(buttonText.activeInHierarchy == true)
        {
            buttonText.SetActive(false);
            buttonNextText.SetActive(true);
        }
        else if (buttonText.activeInHierarchy == false)
        {
            buttonText.SetActive(true);
            buttonNextText.SetActive(false);
        }

    }


}
