using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Wall_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public float detect_Range = 20f;

    public GameObject Wall_obj;

    private bool wallMakerActive;
    public bool inRange;
    public Vector3 direction;
    public Quaternion rotation;
    void Start()
    {
        Wall_obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            wallMakerActive = true;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            wallMakerActive = false;
        }

        if (wallMakerActive)
        {
            
        }
        else
        {
            Wall_obj.SetActive(false);
        }
    }

    public void Update_WallMaker()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit rayhit;
        if (Physics.Raycast(ray, out rayhit, detect_Range))
        {
            inRange = true;
            direction = rayhit.point;
            rotation = Quaternion.LookRotation(ray.direction);
        }
        else
        {
            inRange = false;
        }

        if (inRange)
        {
            Wall_obj.transform.position = direction;
            rotation = new Quaternion(Wall_obj.transform.rotation.x, Wall_obj.transform.rotation.y,
                Wall_obj.transform.rotation.z, Wall_obj.transform.rotation.w);
            Wall_obj.transform.rotation = rotation;
            Wall_obj.SetActive(true);
            
        }
    }
}
