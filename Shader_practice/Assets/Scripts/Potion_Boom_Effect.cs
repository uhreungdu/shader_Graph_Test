using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_Boom_Effect : MonoBehaviour
{
    // Start is called before the first frame update
    public float delay = 3f;
    public float countdowm;
    public bool check_boom;
    public GameObject Boom_Effect;
    void Start()
    {
        countdowm = delay;
        check_boom = false;
    }

    // Update is called once per frame
    void Update()
    {
        countdowm -= Time.deltaTime;
        if (countdowm <= 0f && !check_boom)
        {
            Boom();
            check_boom = true;
        }
    }

    public void Boom()
    {
        //터지는 이펙트 발동
        //Instantiate(Boom_Effect, transform.position, transform.rotation);
        //현재 보이는 방향으로 발사
        
        
        Destroy(gameObject);
    }
}
