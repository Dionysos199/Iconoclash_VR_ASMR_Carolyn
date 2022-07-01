using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossMalevitchScript : MonoBehaviour
{
    Cloth cloth;
    // Start is called before the first frame update
    void Start()
    {
        cloth = GetComponent<Cloth>();
    }

    // Update is called once per frame
    public void setActive(float checkPoint)
    {
        if(checkPoint == 3)
        {
            cloth.useGravity = true;
        }
    }
}
