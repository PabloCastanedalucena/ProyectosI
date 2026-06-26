using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
public class Crono : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoCrono;
    [SerializeField] private float tiempo;

    private int tiempominutos, tiemposegudos, tiempodecimasdesegundo;

    void Cronometro()
    {

        tiempo += Time.deltaTime;

        tiempominutos=Mathf.FloorToInt(tiempo/60);
        tiemposegudos=Mathf.FloorToInt(tiempo%60);
        tiempodecimasdesegundo=Mathf.FloorToInt((tiempo%1)*100);

        textoCrono.text=string.Format("{0:00},{1:00},{2:00}", tiempominutos, tiemposegudos, tiempodecimasdesegundo);
    }
    
    void Update()
    {
        Cronometro();
    }
}


