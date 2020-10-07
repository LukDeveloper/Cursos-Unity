using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatAula : MonoBehaviour
{
    public GameObject prefab;      //Variavel que recebera um objeto, um cubo por exemplo
    void Start()
    {
        GameObject[] objetos = GameObject.FindGameObjectsWithTag("Respawn"); //Procurar por todos os objetos com a tag "Respawn" e guarda-las no Array

        for (int n = 0; n < objetos.Length; n++)
        {    //Desativando todos os objetos de um Array de GameObject
            objetos[n].SetActive(false);
        }

        for (int i = 1; i <= 10; i++)
        {    //Debugando numeros inteiros
            Debug.Log(i);
        }

        for (int i = 0; i <= 10; i = i + 2)
        {    //Debugando numeros pares
            Debug.Log(i);
        }

        for (float x = 0; x <= 10; x = x + 1.1f)
        {
            Vector3 newPosition = new Vector3(x, 0, 0);     //Setando a posição conforme o valor que o contador do "for" recebe
            Instantiate(prefab, newPosition, transform.rotation); //Instanciando (criando) prefab's na cena, onde apenas o eixo X é diferente entre eles
        }
    }
}
