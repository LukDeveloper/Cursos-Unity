using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresAula : MonoBehaviour
{
    public int x, y;
    public bool booleana1, booleana2, booleana3;

    public string txt1, txt2, txt3;

    void Start()
    {
        y = x++;     //Acontece y = x  e  x = x + 1
        y = ++x;     //Acontece x = x + 1  e  y = x;

        if ((booleana1 == true && booleana2 == true) || (booleana1 == false && booleana2 == false))
        {
            Debug.Log("Entrou no if");
        }
    }

    void Update()
    {
        booleana1 = booleana2 ^ booleana3;       //" ^ " Simbolo de diferenciação que retornará true ou false, se forem diferentes, é retornado true e se forem iguais, é retornado false

        x = y % 5;      //"x" recebera o resto da divisão de y por 5

        booleana1 = booleana2 && booleana3;      //Se ambas booleana2 e booleana3 forem verdadeiras booleana1 ficara verdadeira tambem, e se forem ambas falsas a booleana1 ficara falsa tambem
        booleana1 = booleana2 || booleana3;      //Se a booleana2 ou booleana3 for verdadeira booleana1 ficara verdadeira tambem, e se forem ambas verdadeiras a booleana1 ficara verdadeira tambem
        booleana1 &= booleana2;                  //A booleana1 só sera verdadeira se a booleana2 for tambem
        booleana1 = booleana1 | booleana2;       //A booleana1 só sera verdadeira se a booleana1 ou booleana2 for tambem
        booleana1 = (x > 0) ? true : false;      //Se x for maior que 0, booleana1 recebe true e se n ela recebe false
        txt1 = txt2 ?? txt3;                     //Se txt2 for diferente de null txt1 recebe txt2, se txt2 for null, txt1 recebe txt3
        //Não funciona com classe gameObject
    }
}