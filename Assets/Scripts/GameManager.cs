using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool yaEjecutado = false;
    [SerializeField] Personaje capsula1, capsula2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && yaEjecutado == false) 
        {
            PrepararPersonajes();
            yaEjecutado=true;
        }
    }
    private void PrepararPersonajes()
    {
        capsula1.Nombre = "fallguy";
        capsula1.Vida = 50;
        capsula2.Nombre = "MrBean";
        capsula2.Vida = 100;
        capsula1.Nivel = capsula1.CalcularNivel(capsula1.Experiencia);
        capsula2.Nivel = capsula2.CalcularNivel(capsula2.Experiencia);
        Debug.Log(capsula1.Nivel);
        Debug.Log(capsula2.Nivel);
    }
}
