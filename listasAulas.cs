using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listasAulas : MonoBehaviour
{
    public GameObject[] objetosArray;      //Array = listas com tamanhos fixos

    //public List<GameObject> objetosList;  //List = permite ser escalavel quanto ao seu tamanho, estrutura mais dinamica

    public List<GameObject> objetosList = new List<GameObject>();  //Forma correta de criar a List, visto que muitas das vezes ela não inicializada numa função

    void Start()
    {
        for (int n = 0; n < objetosArray.Length; n++)
        {    //Desativando todos os objetos de um Array de GameObject
            objetosArray[n].SetActive(false);
        }

        for (int i = 0; i < objetosList.Count; i++)
        {    //Desativando todos os objetos de uma List de GameObject
             //Numero de elementos da lista
            objetosList[i].SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {        //Ao pressionar a tecla E ....
            Destroy(objetosList[3]);            //O objeto da List na posição indicada dentro dos conchetes é destruido
            objetosList.Remove(objetosList[3]);      //O objeto na posição indicada é removido da List
        }

        if (Input.GetKeyDown(KeyCode.F) && objetosList.Count > 0)
        {        //Ao pressionar a tecla F e onumero de elementos dentro da List for maior que 0 ...
            Destroy(objetosList[objetosList.Count - 1]);            //O ultimo objeto da List é destruido
            objetosList.Remove(objetosList[objetosList.Count - 1]);      //O ultimo objeto é removido da List
        }

        if (Input.GetKeyDown(KeyCode.T))
        {    //Ao pressionar a tecla T ...
            GameObject objetoTemporario = new GameObject("objeto vazio");  //Setando objeto recem criados em uma variavel
                                                                           //nome do objeto
            objetosList.Add(objetoTemporario);      //Adicionando o objeto dentro da variavel objetoTemporario na List, sendo sempre o ultimo elemento dela assim que adicionado
        }
    }
}