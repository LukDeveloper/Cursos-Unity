using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasseEstatica2 : MonoBehaviour
{
    public int resultado;

    void Start()
    {
        resultado = ClasseEstatica.Multiplicar(2, 5);  //Passando dois valores inteiros para o metodo Multiplicar presente
                                                       // na "ClasseEstatica" e o retorno desta função é setado na variavel resultado
    }

    void Update()
    {

    }
}
