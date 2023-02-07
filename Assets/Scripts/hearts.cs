using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hearts : MonoBehaviour
{
    public GameObject[] hearts;
    public bool perdeu_vida = false;
    public int vida = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(perdeu_vida)
        {
            vida--;
            Destroy(hearts[vida].GameObject)
        }
    }
}
