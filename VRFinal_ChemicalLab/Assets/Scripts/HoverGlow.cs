using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverGlow : MonoBehaviour
{
    MeshRenderer MR;

    // Start is called before the first frame update
    void Start()
    {
        MR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GlowIt()
    {
        MR.material.EnableKeyword("_EMISSION");
    }

    public void StopGlowIt()
    {
        MR.material.DisableKeyword("_EMISSION");
    }
}
