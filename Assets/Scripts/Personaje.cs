using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Start is called before the first frame update
    private string nombre;
    private float vida;
    private float experiencia;
    private float nivel;

    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Nivel { get => nivel; set => nivel = value; }

    public float CalcularNivel(float experiencia)
    {
        float level;
        level = experiencia / 1000;
        return level;
    }
    public void Atacar()
    {

    }
    public void Saltar()
    {

    }
}
