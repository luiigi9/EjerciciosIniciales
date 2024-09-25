using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaInicial;
    [SerializeField] Personaje Personaje;
    float vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        Personaje.Vida = vidaInicial;
        vidaActual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float RecibirCura(float cantidad)
    {
        if (cantidad > 0)
        {
            return vidaActual + cantidad;
        }
        else
        {
            return -1;
        }
    }
    public float RecibirDanyo(float cantidadD)
    {
        if (cantidadD > 0)
        {
            vidaActual -= cantidadD;
            if(vidaActual > 0)
            {
                return vidaActual;
            }
            else
            {
                return 0;
            }
        }

        else
        {
            return -1;
        }
    }
}
