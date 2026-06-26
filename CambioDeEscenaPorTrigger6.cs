using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscenaPorTrigger6 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "X")
        {
            SceneManager.LoadScene("EscenaAgarre7");
        }
    }
}
