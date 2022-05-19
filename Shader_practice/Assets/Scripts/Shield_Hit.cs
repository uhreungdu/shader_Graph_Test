using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_Hit : MonoBehaviour
{
    public GameObject ripplesVFX;

    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
/*
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Untagged")
        {
            var ripples = Instantiate(ripplesVFX, transform) as GameObject;
            var psr = ripples.GetComponent<ParticleSystemRenderer>();
            mat = psr.material;
            mat.SetVector("SphereMask_Center",col.contacts[0].point);
            Destroy(ripples,2);
        }
    }
*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Untagged")
        {
            var ripples = Instantiate(ripplesVFX, transform) as GameObject;
            var psr = ripples.GetComponent<ParticleSystemRenderer>();
            mat = psr.material;
            mat.SetVector("SphereMask_Center",other.ClosestPoint(transform.position));
            print(mat.GetColor("MainColor"));
            Destroy(ripples,2);
        }
    }
}
