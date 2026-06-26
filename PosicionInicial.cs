using UnityEngine;
using UnityEngine.SceneManagement;

public class PosicionInicial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("CambiarEscena", 10f);
    }


    void CambiarEscena()
    {
        SceneManager.LoadScene("EscenaAgarre");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
