using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listAula : MonoBehaviour
{
    public int[] numero;         //Array de inteiros

    [Space(20)]                  //Espaço visual entre os atributos do componente no inspector
    public string[] nomes;      //Array de nomes
    public Vector3[] posicoes;    //Array de posições
    float tempo;
    int indice = 0;

    public GameObject[] objetos;

    void Start()
    {
        numero = new int[50];          //Inicializando o array com o tamanho 50
        numero[2] = 15;                //Setando um valor no elemento numero 2 do array

        posicoes = new Vector3[50];    //Inicializando o array com o tamanho 50

        for (int i = 0; i < nomes.Length; i++)
        {       //Varrendo array de nomes
                //tamanho do array
            Debug.Log(nomes[i]);
        }
        for (int n = 0; n < objetos.Length; n++)
        {    //Desativando todos os objetos de um Array de GameObject
            objetos[n].SetActive(false);
        }
    }

    void Update()
    {
        tempo += Time.deltaTime;        //Incremento de tempo (de 1 em 1 Segundo)
        if (tempo >= 1)
        {                  //Se a variavel tempo for >= a 1, então...
            tempo = 0;                  //A variavel tempo recebe 0
            posicoes[indice] = transform.position;  //O vetor posições recebe a posição do detentor do script nos eixos X,Y,Z
            indice++;                   //A variavel indice recebe um incremento
        }
    }
}