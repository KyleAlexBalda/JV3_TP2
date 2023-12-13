using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Input_scanner : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem radar;
    protected bool letPlay = true;  
    private ActionBasedController controller;

    public InputActionReference radarButton;
    
    // Update is called once per frame
    void Update()
    {
     
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
        radarButton.action.performed += Action_performed;
    }
   

    private void Action_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj) {
        Debug.Log("Select Button is pressed : " + radar);
        radar.Play();
    }
}
