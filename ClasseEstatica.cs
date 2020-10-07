using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classes estaticas não precisam estar estar associadas a nada
static public class ClasseEstatica              //Criando uma classe estática
{
    static public int Multiplicar(int val1, int val2){      //Criando um metodo da classe estática que recebe via parametro 2 inteiros e retorna o resultado da multiplicação dos mesmos
        return val1 + val2;
    }
}
