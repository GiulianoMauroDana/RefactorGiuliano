using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    [Range(1, 20)]
    int Probabilidad_Critico;
    int Dado = Random.Range(0, Probabilidad_Critico);
    int valorGolpeCritico;
    public void DañoCritico()
    {       

        if (Dado > valorGolpeCritico)
        {
            Debug.Log("Golpe Critico");
        }
        else
        {
            Debug.Log("Golpe Normal");
        }

    }
}
