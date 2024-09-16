using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H, M, S;
    // Start is called before the first frame update
    void Start()
    {
        if (H >= 0 && H < 24 && M >= 0 && M < 60 && S >= 0 && S < 60)
        {
            Debug.Log("La hora introducida es valida, son las " + H + ":" + M + ":" + S);
        }
        else
        {
            Debug.Log("La hora introducida no es valida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
