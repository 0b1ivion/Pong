using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballhaviour : MonoBehaviour
{
    private Rigidbody rb;
    public float ballThrust;
    public Vector3 vec3;
    // Start is called before the first frame update
    void Start()
    {
        vec3 = transform.forward;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * ballThrust, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
