using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio01 : MonoBehaviour
{
    public valorFueza
    public float Fuerza = valorFueza;
    private Rigidbody2D rb2d;
    private void Start()
    {
        personaje = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Verical");

        Vector2 Velocidad = new Vector2(x, y);

        personaje.AddForce(Velocidad * Fuerza * Time.deltaTime);

    }
}
