using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo6 : MonoBehaviour
{
    public float timeRemaining;
    public int Vermelho = 1;

    Light Green;
    Light Yellow;
    Light Red;

    Collider m_collider;

    void Start()
    {
        timeRemaining = 30f;
        m_collider = GetComponent<Collider>();
        m_collider.enabled = true;

        Green = GameObject.Find("G6").GetComponentInChildren<Light>();
        Yellow = GameObject.Find("Y6").GetComponentInChildren<Light>();
        Red = GameObject.Find("R6").GetComponentInChildren<Light>();

    }

    void Update()
    {
        
        if(timeRemaining > 15) // verde - Vermelho -1
        {
            
            Vermelho = -1;
            timeRemaining -= Time.deltaTime;
            Red.intensity = 0;
            Yellow.intensity = 0;
            Green.intensity = 2;
        }
        else if (timeRemaining <= 15 && timeRemaining > 10) // amarelo - Vermelho -1
        {
            timeRemaining -= Time.deltaTime;
            Red.intensity = 0;
            Yellow.intensity = 2;
            Green.intensity = 0;
        }
        else if(timeRemaining <= 10 && timeRemaining > 0) // vermelho - Vermelho 1
        {
            Vermelho = 1;
            timeRemaining -= Time.deltaTime;
            Red.intensity = 2;
            Yellow.intensity = 0;
            Green.intensity = 0;
        }
        else
        {
            timeRemaining = 30;
        }

        if(Vermelho == 1)
            m_collider.enabled = true;
        else
            m_collider.enabled = false;    
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("passou no vermelho 6");
    }
}