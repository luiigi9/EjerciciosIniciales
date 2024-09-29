using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] int danyoMinimo, danyoMaximo, capTotal;
    [SerializeField] bool auto;
    private int municion;
    // Start is called before the first frame update
    void Start()
    {
        municion = capTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int UtilizarArma()
    {
        if (municion > 0)
        {
            municion--;
            return 0;
        }
        else 
        { 
            return -1;
        }
    }
    int RecargarArma()
    {
        if (municion != capTotal)
        {
            municion = capTotal;
            return 0;
        }
        else 
        { 
            return -1; 
        }
    }
}
