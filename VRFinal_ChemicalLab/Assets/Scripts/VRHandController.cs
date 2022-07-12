using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRHandController : MonoBehaviour
{
    [SerializeField] InputActionReference ControllerActionGrip;
    [SerializeField] InputActionReference ControllerActionTrigger;

    private Animator _handAnimator;

    private void Awake()
    {
        ControllerActionGrip.action.performed += GripPress;
        ControllerActionTrigger.action.performed += TriggerPress;

        _handAnimator = GetComponent<Animator>();
    }

    private void GripPress(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }

    private void TriggerPress(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
