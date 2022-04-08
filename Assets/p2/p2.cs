using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2 : MonoBehaviour
    
{public float producto1;
    public float producto2;
    public float producto3;
    public float montoDisponible;

    // Start is called before the first frame update
    void Start()
    {
        if (montoDisponible > producto1 + producto2 + producto3)
        {
            Debug.Log("La suma de los productos no supera el monto disponible");
        }
        if (montoDisponible < producto3 + producto2 + producto1)
        {
            Debug.Log("El monto disponible no es suficiente");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
