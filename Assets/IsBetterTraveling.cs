using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBetterTraveling : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public Transform tranform;
    private bool isReversed;
    void Start()
    {
        isReversed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tranform.position.z > -1)
            isReversed=true;
        if (tranform.position.z < -10)
            isReversed = false;
        if (!isReversed)
        {
            cam.fieldOfView = cam.fieldOfView*1.001f;
            transform.position = (new Vector3(transform.position.x,transform.position.y ,transform.position.z + 0.01f));
        }
        else
        {
            cam.fieldOfView = cam.fieldOfView*.999f;
            transform.position = (new Vector3(transform.position.x,transform.position.y ,transform.position.z - 0.01f));
        }
        
    }
}
