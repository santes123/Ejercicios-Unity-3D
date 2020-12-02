using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodos : MonoBehaviour
{
    // Start is called before the first frame update

    private int numero1 = 6;
    private int numero2 = 4;

    void Start()
    {
        //mostrarSuma();
        Debug.Log(CalcularSuma(numero1, numero2));
    }

    // Update is called once per frame
    void Update()
    {
        //mostrarSuma();
        Debug.Log(CalcularSuma(numero1, numero2));
    }

    //accion
    void mostrarSuma()
    {
        Debug.Log("La suma de los numeros es: " + (this.numero1 + this.numero2));
    }

    //funcion
    int CalcularSuma(int numero1, int numero2)
    {
        int suma = numero1 + numero2;
        return suma;
    }
}
