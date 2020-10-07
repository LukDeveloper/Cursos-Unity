using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criarobjetos : MonoBehaviour
{
    public Vector3 posicao, rotacao;
    public GameObject prefab;

    GameObject esfera;   //Variavel não acessivel pelo inspector
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {    //criar objeto atraves do click do mouse na cena
            GameObject.CreatePrimitive(PrimitiveType.Cube);     //criar objeto na posiçao 0,0,0
        }

        if (Input.GetMouseButtonDown(0))
        {    //criar objeto atraves do click do mouse na cena
            GameObject objeto = GameObject.CreatePrimitive(PrimitiveType.Cube);     //criar objeto e coloca-lo na variavel objeto
            objeto.transform.position = posicao; //setando a localização do objeto criado pela o valor que a variavel posicao receber
            objeto.transform.rotation = Quaternion.Euler(rotacao);  //setando a rotaçao do objeto criado pela o valor que a variavel rotacao receber
        }

        if (Input.GetMouseButtonDown(0))
        {      //****MELHOR FORMA DE CRIAR OBJETOS****
            Instantiate(prefab, posicao, Quaternion.Euler(rotacao)); //criando objeto, utiliza-se a variavel que recebe o tipo de objeto, a posiçao e sua rotaçao
        }

        if (Input.GetMouseButtonDown(0))
        {
            esfera = Instantiate(prefab, posicao, Quaternion.Euler(rotacao)) as GameObject; //criando objeto, utiliza-se a variavel que recebe o tipo de objeto, posicionamento e passando ele para uma variavel
            //GameObject esfera = (GameObject) Instantiate(prefab,posicao,Quaternion.Euler(rotacao)); //Forma de representar a conversao do objeto para GameObject tambem
            esfera.AddComponent(typeof(Rigidbody)); //adicionando um componente ao objeto criado e setado na variavel anteriormente
            esfera.GetComponent<Rigidbody>().isKinematic = true; //ativou o componente "isKinematic" do objeto
        }                                                                             //objeto não caira
        if (esfera != null)
        {  //Se houver algo na variavel esfera
            esfera.transform.Rotate(50 * Time.deltaTime, 0, 0);     //Aplicaçao da rotação no objeto criado
        }

        Instantiate(prefab);    //Criar varios objetos em posições aleatorias

        Instantiate(prefab, transform.position, transform.rotation);    //Criar varios objetos originados do objeto em que esta o script
    }   //objeto criado//posiçao e rotação do hospedeiro do script
}
