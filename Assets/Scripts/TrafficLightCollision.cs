using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightCollision : MonoBehaviour
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

        Green = GameObject.Find("Green").GetComponentInChildren<Light>();
        Yellow = GameObject.Find("Yellow").GetComponentInChildren<Light>();
        Red = GameObject.Find("Red").GetComponentInChildren<Light>();

    }

    void Update()
    {
        
        if(timeRemaining > 15) // verde - Vermelho -1
        {
            Debug.Log("verde");
            
            Vermelho = -1;
            timeRemaining -= Time.deltaTime;
            Red.intensity = 0;
            Yellow.intensity = 0;
            Green.intensity = 2;
        }
        else if (timeRemaining <= 15 && timeRemaining > 10) // amarelo - Vermelho -1
        {
            Debug.Log("amareloi");
            timeRemaining -= Time.deltaTime;
            Red.intensity = 0;
            Yellow.intensity = 2;
            Green.intensity = 0;
        }
        else if(timeRemaining <= 10 && timeRemaining > 0) // vermelho - Vermelho 1
        {
            //Debug.Log("vermeio");
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
        Debug.Log("passou no vermeio222");
    }
}
