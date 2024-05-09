using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position = target.position - offset;
    }
}
