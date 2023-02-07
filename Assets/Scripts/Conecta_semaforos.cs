using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Conecta_semaforos : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;

    [SerializeField] TrafficLightCollision semaforo1;
    [SerializeField] Semaforo2 semaforo2;
    [SerializeField] Semaforo3 semaforo3;
    [SerializeField] Semaforo4 semaforo4;
    [SerializeField] Semaforo5 semaforo5;
    [SerializeField] Semaforo6 semaforo6;
    //[SerializeField] Semaforo7 semaforo7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(semaforo1.passou_verde || semaforo2.passou_verde || semaforo3.passou_verde || semaforo4.passou_verde || semaforo5.passou_verde || semaforo6.passou_verde)
        //     Debug.Log("verde");
        // if(semaforo2.passou_amarelo)
        //     Debug.Log("amarelo2");    
        if(semaforo1.passou_verde || semaforo2.passou_verde || semaforo3.passou_verde || semaforo4.passou_verde || semaforo5.passou_verde || semaforo6.passou_verde)
            score += 100;
        if(semaforo1.passou_vermelho || semaforo2.passou_vermelho || semaforo3.passou_vermelho || semaforo4.passou_vermelho || semaforo5.passou_vermelho || semaforo6.passou_vermelho)
            score -= 200;
        if(semaforo1.passou_amarelo || semaforo2.passou_amarelo || semaforo3.passou_amarelo || semaforo4.passou_amarelo || semaforo5.passou_amarelo || semaforo6.passou_amarelo)
            score -= 50;

        scoreText.text = "Score: " + score.ToString();  
    }
}
