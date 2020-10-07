using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{
    public int numero;
    public float numF;
    public GameObject[] objetos;
    public GameObject cubo;

    void Update()
    {
        //O Valor maximo do sorteio nunca é atingido

        if(Input.GetKeyDown (KeyCode.E)){       //Gerar numero inteiro aleatório ao pressionar a tecla E
            numero = Random.Range(0, 50);       //Valor entre 0 e 50
        }  

         if(Input.GetKeyDown (KeyCode.F)){      //Gerar numero quebrado aleatório ao pressionar a tecla F
            numF = Random.Range(0.0f, 50.0f);   //Valor entre 0.0f e 50.0f
        } 

         if(Input.GetKeyDown (KeyCode.T)){      //Gerar numero quebrado e inteiro aleatório ao pressionar a tecla T
            numero = Random.Range(-1, 1);       //Valor entre -1 e 1
            numF = Random.Range(-1.0f, 1.0f);   //Valor entre -1.0f e 1.0f
        } 

        if(Input.GetKeyDown (KeyCode.R)){                   //Gerar numero inteiro aleatório ao pressionar a tecla R
            numero = Random.Range(0, objetos.Length);       //Valor entre 0 e o numero de elementos da lista
            Instantiate (objetos[numero]);                  //Instanciando elementos aleatorio que estão na lista
        }

        if(Input.GetKeyDown (KeyCode.P)){                   //Gerar local aleatório ao pressionar a tecla P
            transform.position = new Vector3(Random.Range(0, 50), Random.Range(0, 50), Random.Range(0, 50));
        }

         if(Input.GetKeyDown (KeyCode.M)){                   //Gerar numero inteiro aleatório ao pressionar a tecla M
            GameObject instancia = Instantiate(cubo) as GameObject;  //Declarando uma variavel que recebera o comando de instancia de um objeto
            instancia.transform.position = new Vector3(Random.Range(0, 50), Random.Range(0, 50), Random.Range(0, 50)); //Executando o comando de instancia do objeto e setando o local de forma aleatória
        }

        Instantiate (objetos[Random.Range(0, objetos.Length)]); //Instanciando elementos aleatorio que estão na lista

        int num1 = Random.Range (900,1000);
    }
}

//Geração de numeros aleatório pela maquina///////////////////////////////////////////
// 15:30:45  Horário no computador                                                  //
//(45*7)/11 = numero aleatório normalizado                                          //
//(numero aleatorio normalizado anterio * 7)/11 = novo numero aleatório normalizado //
//////////////////////////////////////////////////////////////////////////////////////