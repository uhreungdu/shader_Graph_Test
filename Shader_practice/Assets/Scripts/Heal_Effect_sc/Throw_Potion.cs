using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Potion : MonoBehaviour
{
    public float throwForce = 40f;

    public GameObject Throw_prefeb;

    public bool isAimming;
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
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("dd");
        }
    }

    void Throw_Object()
    {
        GameObject prefeb = Instantiate(Throw_prefeb, transform.position, transform.rotation);
        Rigidbody rb = prefeb.GetComponent<Rigidbody>();
        Vector3 mousePos = Input.mousePosition;
        Vector3 transPos = Camera.main.ScreenToWorldPoint(mousePos);
        Debug.Log(transPos);
        rb.AddForce(transform.forward * throwForce,ForceMode.VelocityChange);
    }

    void Aim()
    {
        if (!isAimming)
        {
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rayHit;
        float RayLength = 500f;
        int floorMask = LayerMask.GetMask("Floor");
    }
}
