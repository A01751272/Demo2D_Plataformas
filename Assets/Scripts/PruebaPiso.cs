using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPiso : MonoBehaviour
{

    public static bool saltando = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        saltando = false;
        //print("Esta en piso");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        saltando = true;
        //print("Esta saltando");
    }
}
