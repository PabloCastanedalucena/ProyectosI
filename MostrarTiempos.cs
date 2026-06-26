using UnityEngine;
using TMPro;


public class MostrarTiempos : MonoBehaviour
{

    public TextMeshProUGUI textoTiempos;

    void Start()
    {
        var tiempos = GuardadoTiempo.Instance.tiemposPorEscena;
        string resultado = "";

        for (int i = 0; i < tiempos.Count; i++)
        {
            Debug.Log("Escena " + i + ": " + tiempos[i] + " segundos");
            resultado += "Escena " + i + ": " + tiempos[i].ToString("F2") + " s\n";
        }

        textoTiempos.text = resultado;
    }
}
