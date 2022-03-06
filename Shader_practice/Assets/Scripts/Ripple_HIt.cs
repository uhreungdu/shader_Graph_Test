using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Ripple_HIt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shieldRipple;
    private VisualEffect shieldRippleVFX;
    private void OnCollsionEnter(Collision col){
        if(col.gameObject.tag == "Bullet"){
            var ripples = Instantiate(shieldRipple,transform) as GameObject;
            shieldRippleVFX = ripples.GetComponent<VisualEffect>();
            shieldRippleVFX.SetVector3("Sphere_Center",col.contacts[0].point);
            Destroy(ripples, 2);
        }
    }
}
