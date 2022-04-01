using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Autor: Aleny Sof�a Ar�valo Magdaleno
 * Mantiene informaci�n de la salud del personaje
 */
public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;
    public int monedas = 0;

    /*Se declara una variable est�tica llamada instancia*/
    public static SaludPersonaje instance;

    /*Se llama antes que Start, al inicializar la app*/
    private void Awake()
    {
        instance = this;
    }
}
