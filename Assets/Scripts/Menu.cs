using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Se ejecuta cuando el usuario da click sobre el botón jugar
    public void Jugar()
    {
        SceneManager.LoadScene("EscenaMapa");
    }

    public void Jugar2()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
