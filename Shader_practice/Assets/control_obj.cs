using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_obj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject get_obj;
    public GameObject Item_mana;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            get_obj = Resources.Load<GameObject>("Wall_Obstcle_Objs");
            Item_mana = Instantiate(get_obj);
        }
    }
}
