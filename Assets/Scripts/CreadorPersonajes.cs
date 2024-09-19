using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    [SerializeField] Personaje link;
    
    // Start is called before the first frame update
    void Start()
    {
        link.Nombre = "link";
        link.Velocidad = 50;
        link.Vida = 100;
        link.Mover();
        link.Saltar();
        link.Atacar();
    }

    // Update is called once per frame
    
}
