using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
public class ControllerBehavior : MonoBehaviour
{

    public GameObject baseController;
    public GameObject teleportController;

    public InputActionReference ActivateTeleport;
    [Space]

    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    // Start is called before the first frame update
    void Start()
    {
        ActivateTeleport.action.performed += TeleportModeActivate;
        ActivateTeleport.action.canceled += TeleportModeCancel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportModeActivate(InputAction.CallbackContext obj)
    {
        onTeleportActivate.Invoke();
    }

    public void TeleportModeCancel(InputAction.CallbackContext obj)
    {
        Invoke("DeactivateTeleport", 0.1f);
    }

    void DeactivateTeleport()
    {
        onTeleportCancel.Invoke();
    }
}
