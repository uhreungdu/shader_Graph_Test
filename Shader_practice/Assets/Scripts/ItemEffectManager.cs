using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemEffectManager : MonoBehaviour
{
    public float throwForce = 40f;

    public GameObject Throw_prefeb;

    public bool isAimming;
    public string item_name;
    public GameObject Get_Obj;
    public GameObject SetTail_obj;
    public GameObject Item_Obj;
    public GameObject Effect_Obj;
    // Start is called before the first frame update
    void Start()
    {
        item_name = "potion";
        Get_Obj = Resources.Load<GameObject>("Throw_Tail");
        SetTail_obj = Instantiate(Get_Obj);
        SetTail_obj.transform.SetParent(gameObject.transform);
        SetTail_obj.transform.Translate(gameObject.transform.position);
        Get_Obj = Resources.Load<GameObject>("potion");
        Item_Obj = Instantiate(Get_Obj, gameObject.transform.position, Quaternion.identity);
        Item_Obj.transform.SetParent(gameObject.transform);
        Item_Obj.transform.Translate(new Vector3(0,-0.05f,0));
        Item_Obj.transform.Rotate(new Vector3(-90, 0, 0));

    }

    // Update is called once per frame
    void Update()
    {
        if (Item_Obj == null && Effect_Obj == null)
        {
            Destroy(SetTail_obj);
            Get_Obj = Resources.Load<GameObject>("Potion_Effect");
            Effect_Obj = Instantiate(Get_Obj);
            Effect_Obj.transform.SetParent(gameObject.transform);
            Effect_Obj.transform.Translate(gameObject.transform.position);
        }
    }
}
