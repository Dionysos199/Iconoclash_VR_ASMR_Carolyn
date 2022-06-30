using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeadsScript : MonoBehaviour
{
    public int width;
    public int height;
    public List<GameObject> beads;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void createBeadsSheet(float checkPoint)
    {
        Debug.Log("Checkpoint"+ checkPoint+" was reached");
        if (checkPoint == 4)
        {
            int m = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    m++;
                    int index = m % beads.Count;
                    Instantiate(beads[index], transform.position + new Vector3(i, 0, j), Quaternion.Euler(90, 0, 0));
                    Debug.Log(beads[index]);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
