using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class toggle : MonoBehaviour
{
    private void Start()
    {
        var Head = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.Head, Head);

        if (Head.Count == 1)
        {
            UnityEngine.XR.InputDevice device = Head[0];
            //Head[0].TryGetFeatureUsages()
        }

    }
}
