using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Potion : MonoBehaviour
{
    public float throwForce = 40f;

    public GameObject Throw_prefeb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Throw_Object();
        }
    }

    void Throw_Object()
    {
        GameObject prefeb = Instantiate(Throw_prefeb, transform.position, transform.rotation);
        Rigidbody rb = prefeb.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce,ForceMode.VelocityChange);
    }
}
