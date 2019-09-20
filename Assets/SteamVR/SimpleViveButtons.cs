using UnityEngine;
using System.Collections;
public class SimpleViveButtons : MonoBehaviour
{
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private Valve.VR.EVRButtonId touchpadButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;


    private SteamVR_Controller.Device controller{ get{return SteamVR_Controller.Input((int)trackedObj.index);} }
    private SteamVR_TrackedObject trackedObj;

    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }


        if (controller.GetPressDown(triggerButton))
        {
            print("Fire");
        }

        if (controller.GetPressDown(touchpadButton))
        {
            if(controller.GetAxis().x >= 0.5f)
                print("right click on touch pad");
        }

    }
}