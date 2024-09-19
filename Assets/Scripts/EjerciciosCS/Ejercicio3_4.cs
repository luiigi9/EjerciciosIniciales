using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int exp;
    int level;
    // Start is called before the first frame update
    void Start()
    {
        level = 32 + (9 * exp/5);
        Debug.Log(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
