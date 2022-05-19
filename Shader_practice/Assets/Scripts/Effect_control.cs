using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_control : MonoBehaviour
{
    public List<GameObject> effects = new List<GameObject>();

    public List<ParticleSystem> particles = new List<ParticleSystem>();
    // Start is called before the first frame update
    void Start()
    {
        Get_System();
        print(effects.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Play_Particles();
        }
    }

    public void Play_Particles()
    {
        for (int i = 0; i < particles.Count; ++i)
        {
            if (particles[i] != null)
            {
                particles[i].Play();
                print("넣어져 있음" + i);
            }
        }
    }

    public void Get_System()
    {
        for (int i = 0; i < effects.Count; ++i)
        {
            if (effects[i] != null)
            {
                particles.Add(effects[i].GetComponent<ParticleSystem>());
                print("넣어져 있음" + i);
            }
        }
    }
}
