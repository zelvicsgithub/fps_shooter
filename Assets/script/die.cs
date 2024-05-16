using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class die : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
