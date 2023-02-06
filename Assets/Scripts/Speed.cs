using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Speed : MonoBehaviour
{
    private float speed;
    public TextMeshProUGUI scoreText;

    void Start()
    {

    }

    void Update()
    {
        StartCoroutine(CalculateSpeed());
        float aux = 3*speed;
        scoreText.text = aux.ToString("0");
    }

    IEnumerator CalculateSpeed()
    {
        Vector3 lastPosition = transform.position;
        yield return new WaitForFixedUpdate();
        speed = (lastPosition - transform.position).magnitude / Time.deltaTime;
    }
}
