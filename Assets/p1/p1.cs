using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1 : MonoBehaviour
{
    public float valor1;
    public float valor2;
    // Start is called before the first frame update
    void Start()
    {
        if (valor1 == valor2)
        {
            Debug.Log("son iguales");
        }
        else
        {
            Debug.Log("no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
