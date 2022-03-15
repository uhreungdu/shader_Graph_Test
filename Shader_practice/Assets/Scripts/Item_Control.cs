using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Item_Control : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Item_mana;
    public GameObject get_obj;
    void Start()
    {
        get_obj = Resources.Load<GameObject>("Item_Effect_Manager");
        Item_mana = Instantiate(get_obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Aim()
    {
        
    }
}
