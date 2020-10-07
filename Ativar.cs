using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar : MonoBehaviour
{
    //SetActive - Ativar ou desativar o objeto inteiro 
    //Enabled - Ativar ou desativar componentes do objeto 

    public GameObject objeto, objeto2;

    public bool condicao;
    void Start()
    {
        gameObject.SetActive (false); //Desativando objeto todo

        GetComponent<MeshRenderer>().enabled = false; //Desabilitando componente do objeto

        if(objeto.activeInHierarchy == false){   //Verificando se o objeto esta ativado na cena
            Debug.Log("O objeto esta desativado");
        }else{
            Debug.Log("Esta ativado");
        }

         if(GetComponent<MeshRenderer>().enabled == true){   //Verificando se o componente do objeto esta ativado na cena
            Debug.Log("O componente esta ativado");
        }else{
            Debug.Log("Esta desativado");
        }

        Debug.Log(objeto2.activeSelf); //Dizer se o objeto esta ativado ou desativado e retorna true ou false

        if(GetComponent<Camera>().isActiveAndEnabled){  //Dizer se o objeto esta ativado tanto o objeto como um todo, quanto seus componentes
            Debug.Log("A camera esta ativada");
        }
    }

    void Update()
    {
        GetComponent<Light>().enabled = condicao; //Habilitar ou desabilitar objeto conforme o valor da variavel "condicao"

        if(Input.GetKeyDown(KeyCode.F)){  //Habilitar ou desabilitar objeto conforme o valor da variavel "condicao" setado pelo pressionar do botão
            condicao =! condicao; //"condicao recebe o inverso do seu valor, EX: true = false & flase = true
        }
    }
}
