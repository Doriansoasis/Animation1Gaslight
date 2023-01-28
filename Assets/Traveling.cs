using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traveling : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public Transform tranform;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cam.fieldOfView = cam.fieldOfView*0.9997f;
        transform.position = (new Vector3(transform.position.x,transform.position.y ,transform.position.z - 0.004f));
    }
}
