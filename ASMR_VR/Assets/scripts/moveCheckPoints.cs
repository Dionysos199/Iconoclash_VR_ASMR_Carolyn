using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCheckPoints : MonoBehaviour
{
    private GameObject nextCheckpoint;
    public List<GameObject> checkpoints;
    Transform _transform;
    int index = 1;
    Vector3 direction;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
        _transform.position = checkpoints[0].transform.position;
        nextCheckpoint = checkpoints[1];
        _transform.rotation = Quaternion.FromToRotation(Vector3.forward, direction);

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("you reached a checkpoint");
        Debug.Log(other);
        if (other.gameObject == nextCheckpoint)
        {
            Debug.Log("you reached a checkpoint");
        }
    }
    // Update is called once per frame
    void Update()
    {

        // direction = nextCheckpoint.transform.position - _transform.position;

        // Calculate a rotation a step closer to the target and applies rotation to this object
        // transform.rotation = Quaternion.LookRotation(direction);

        // Draw a ray pointing at our target in
        //  Debug.DrawRay(transform.position, direction, Color.red);

        //  _transform.localPosition += Vector3.forward * Time.deltaTime;


        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, nextCheckpoint.transform.position, step);
        Vector3 deltaPosition = transform.position - nextCheckpoint.transform.position;
        if (deltaPosition.magnitude < 0.1)
        {
            if(index < checkpoints.Count-1) index++;
            nextCheckpoint = checkpoints[index];
        }
    }
}
