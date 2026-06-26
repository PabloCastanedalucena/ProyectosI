using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GuardadoTiempo : MonoBehaviour
{
    public static GuardadoTiempo Instance;

    private float tiempoInicioEscena;
    public List<float> tiemposPorEscena = new List<float>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Si no es la primera escena, guarda el tiempo de la anterior
        if (tiempoInicioEscena != 0)
            tiemposPorEscena.Add(Time.time - tiempoInicioEscena);

        // Reinicia el contador para la nueva escena
        tiempoInicioEscena = Time.time;
    }

    public float ObtenerTiempoActual()
    {
        return Time.time - tiempoInicioEscena;
    }
}
