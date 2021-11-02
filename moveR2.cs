using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveR2 : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-(450 * Time.deltaTime), -(100 * Time.deltaTime), -(500 * Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
