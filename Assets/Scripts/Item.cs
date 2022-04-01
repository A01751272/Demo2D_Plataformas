using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Aleny Sof�a Ar�valo Magdaleno
 * A01751272
 * Detecta las colisiones con el personaje
 */

public class Item : MonoBehaviour
{
    [SerializeField]
    private AudioSource efectoMoneda;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Hace visible la explosión
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            // gameObject.transform.GetChild(0) // Es transform de la explosión
            // gameObject.transform.GetChild(0).gameObject // Explosión

            // Oculta la moneda
            GetComponent<SpriteRenderer>().enabled = false;

            //Destruye la moneda
            Destroy(gameObject, 0.3f);

            // Destruye el personaje
            // Destroy(collision.gameObject, 0.2f);

            //Cuenta monedas recolectadas
            SaludPersonaje.instance.monedas++;
            HUD.instance.ActualizarContadorMonedas();

            // Efecto de sonido
            efectoMoneda.Play();
        }
    }
}
