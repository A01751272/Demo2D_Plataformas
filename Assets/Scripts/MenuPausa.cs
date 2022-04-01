using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 Autor: Aleny Sofía Arévalo Magdaleno
 El comportamiento del menú pausa. Pausar y reanudar.
*/
public class MenuPausa : MonoBehaviour
{
    // SerializeField permite acceder a la variable desde fuera, incluso si es privada
    [SerializeField]
    private GameObject panelPausa;
    // Definimos el estado de pausa en false
    public bool estaPausado = false;

    public static MenuPausa instance;

    private void Awake()
    {
        instance = this;
    }

    public void Pausar()
    {
        // Cambiamos el estado
        estaPausado = !estaPausado;
        // Activa el panel de pausa al mandarle como argumento true (estado de estaPausado)
        panelPausa.SetActive(estaPausado);

        /* Si el valor de timeScale es 0, no hay actualizaciones (se para el juego)
           Si el valor es 1, hay actualizaciones (corre normal)
           Puedes usar valores diferentes para aumentar o disminuir la velocidad
        */
        Time.timeScale = estaPausado ? 0 : 1;
    }

    private void Update()
    {
        // Si se presiona la tecla esc, se manda llamar a la función Pausa
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }
}
