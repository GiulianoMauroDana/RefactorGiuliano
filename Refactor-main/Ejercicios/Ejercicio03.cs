using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    int resistencia;
    int vida;

    void RecibirDaño(int daño)
    {
        int dañonuevo = daño;
        if (resistencia > 5)
        {
            dañonuevo -= 2;

        }

        vida -= dañonuevo;
        
    }
}
