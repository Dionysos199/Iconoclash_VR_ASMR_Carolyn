using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableChairScript : MonoBehaviour
{
    public float lambda;
    bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(shrink());   
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered)
        {

            transform.localScale /= 1f + 1 / lambda;
        }
    }
   /* IEnumerator shrink() { 
        while (triggered)
        {
            transform.localScale /= 1f + 1 / lambda;
            Debug.Log("nananana");
        }
        yield return null;
    }*/

    public void trigger(float checkpoint)
    {
        if (checkpoint==1)
        {
            triggered = true;
        }
    }
}
