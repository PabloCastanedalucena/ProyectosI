using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenaPorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "X")
        {
            SceneManager.LoadScene("EscenaAgarre2");
        }
    }
}

