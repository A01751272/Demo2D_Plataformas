using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 Autor: Aleny Sofía Arévalo Magdaleno
 Manipular las imágenes de vida (corazones) para que representen la salud del personaje
*/

public class HUD : MonoBehaviour
{
    public static HUD instance;

    // Declaramos las imágenes (corazones)
    public Image corazon1;
    public Image corazon2;
    public Image corazon3;

    public TextMeshProUGUI txtMonedas;

    private void Awake()
    {
        instance = this;
    }

    // Debe conectarse al botón Reanudar
    public void Reanudar()
    {
        MenuPausa.instance.Pausar();
    }

    // Refresca las vidas (imágenes de corazón)
    public void ActualizarVidas()
    {
        int vidas = SaludPersonaje.instance.vidas;
        switch (vidas)
        {
            case 2:
                corazon3.enabled = false;
                break;
            case 1:
                corazon2.enabled = false;
                break;
            case 0:
                corazon1.enabled = false;
                break;
        }
    }

    public void ActualizarContadorMonedas()
    {
        int monedas = SaludPersonaje.instance.monedas;
        txtMonedas.text = monedas.ToString();
    }
}
