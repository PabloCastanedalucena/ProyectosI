using UnityEngine;
using UnityEngine.SceneManagement;

public class PasoAEscenaDos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("CambiarEscena", 10f);
    }


    void CambiarEscena()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
