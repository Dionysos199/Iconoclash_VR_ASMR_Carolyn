using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinusoidalAnimation : MonoBehaviour
{
    public float tetaMax;
    public float deltaDelay;
    public float displacement;
    // Start is called before the first frame update
    void Start()
    {
        float shift=0;
        foreach (Transform child in transform)
        {
            shift+=displacement;
            child.gameObject.transform.position = shift * Vector3.forward+transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float delay = 0;
        
        foreach (Transform child in transform)
        {
            delay += deltaDelay;
            child.gameObject.transform.rotation=Quaternion.Euler( tetaMax *Mathf.Sin(Time.time+delay)-90,-90,90);
        }
    }
}
