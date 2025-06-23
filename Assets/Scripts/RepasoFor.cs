using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    public int numUno;
    public int numDos;
  
    void Start()
    {
        // escribir en consola los numeros enteros del 0 al 4
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    
        // escribir los enteros múltiplos de 3 entre 6 y 30 inclusive
        for (int i = 6; i<= 30; i+=3)  // i+=3 le suma tres y lo guarda en la variable
        {
            Debug.Log(i);
        }

        // escribir los enteros desde 0 a 50 excepto los múltiplos de 7
        for (int i = 0; i>= 50; i++)
        {
            if ( i % 7 != 0) // cuando el resto del numero dividido por 7 es distinto de cero se muestra el número (pq no es múltiplo de 7)
            {
                Debug.Log(i);
            }
        }

        // escribir los enteros entre 100 y 0 (inclusive) de manera descendente
        for (int i = 100; i >= 0; i--)
        {
            Debug.Log(i);
        }

        // escribir los enteros entre dos enteros ingresados por inspector (NO inclusive)
        for (int i = numUno; i < numDos; i++)
        {
            if(i != numUno)
            {
                Debug.Log(i);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
