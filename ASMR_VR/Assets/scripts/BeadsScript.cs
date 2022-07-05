using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeadsScript : MonoBehaviour
{
    public int width;
    public int height;
    public List<GameObject> beads;
    public float frequency;
    public int numberOfWaves;

    int n = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    public IEnumerator beadsCreateCoroutine (float checkpoint)
    {
       while (true)
        {
            n++;
            if(n<4)createBeadsSheet(checkpoint);
            //Debug.Log("new creation");
            yield return new WaitForSeconds(frequency);
        }
    }
    public void createBeadsSheet(float checkPoint)
    {
        Debug.Log("Checkpoint"+ checkPoint+" was reached");
       
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
    public void startCoroutine(float checkPoint)
    {
        if (checkPoint == 4)
        {
            StartCoroutine(beadsCreateCoroutine(checkPoint));
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
