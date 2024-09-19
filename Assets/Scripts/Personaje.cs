using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Start is called before the first frame update
    private string nombre;
    private float vida;
    private float altura;
    private float velocidad;

    public float Vida { get => vida; set => vida = value; }
    public float Altura { get => altura; set => altura = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }

    public void Mover(float x, float y, float z)
    {

    }
    public void Atacar()
    {

    }
    public void Saltar()
    {

    }
}
