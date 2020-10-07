using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
    public bool podePular;

    public float forcaPulo = 5;

    public LayerMask escolhaDeLayers;  //Setar objetos que poderam ser colididos 

    public GameObject objeto;
    void Start()
    {

    }

    void Update()
    {
        RaycastHit pontoDeColisao;  //Variavel que receberá o local onde houver a colisão

        if (Physics.Raycast(transform.position, transform.forward, 10)) //Função Raycast que pede como parametros Raio com o ponto de partida (Objeto com o script), ponto final (Quem ele atingirá) e distancia máxima
        {       //Geralmente a função Raycast quando n tem parametros, ele retorna true ou false
                //Se o objeto com script estiver colindindo frontalmente com outro objeto na cena, então ele retorna true
            Debug.Log("Esta colidindo");
        }
        else
        {  //Se não estiver colidindo, é retornado false
            Debug.Log("Não esta colidindo");
        }

        if (Physics.Raycast(transform.position, transform.forward, out pontoDeColisao, 10))
        {
            //Ponto em que houve a colisão
            Debug.Log(pontoDeColisao.point); //Mostrando o ponto de colisão
            Debug.DrawLine(transform.position, pontoDeColisao.point); //Desenhando uma linha na cena, ela sai do objeto com script e termina no ponto de colisão
            if (pontoDeColisao.transform.gameObject.GetComponent<MeshRenderer>() != null)
            { //Se o objeto que receber a colisão tiver MeshRenderer então
                pontoDeColisao.transform.gameObject.GetComponent<MeshRenderer>().enabled = false; //Desativando o componente do objeto
                pontoDeColisao.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.green; //Trocando a cor do MeshRenderer do objeto 
            }
        }
        //Permitir ou não o salto do objeto de acordo com sua distancia de outro objeto
        if (Physics.Raycast(transform.position, -Vector3.up, 2))
        {  //Função Raycast que recebe como parametro a posição do objeto que tem o script, um Vector com valor negativo e para cima e a distancia maxima
            podePular = true;   //A variavel podePular recebe true
        }
        else
        {
            podePular = false;  //A variavel podePular recebe false
        }
        if (Input.GetKeyDown(KeyCode.Space) && podePular == true)
        {     //Se a tecla "space" for precionada e a variavel podePular for verdadeira
            GetComponent<Rigidbody>().AddForce(Vector3.up * forcaPulo);  //O objeto com script recebera uma força para cima, força essa que é setada pela variavel "forcaPulo"
        }

        if (Physics.Raycast(transform.position, -Vector3.up, 2, escolhaDeLayers))
        {  //Permite a escolha de Layers, definindo assim em que objeto na cena ele pode colidir
            podePular = true;
        }
        else
        {
            podePular = false;
        }

        if (Input.GetMouseButtonDown(0))
        {   //Quando pressionar o botão do mouse uma vez
            RaycastHit hit;                //Declarando o a variavel que irá receber o ponto de colisão
            Physics.Raycast(transform.position, transform.forward, out hit, 1000);  //
            Instantiate(objeto, hit.point, Quaternion.Euler(hit.normal)); //Instanciando objeto no ponto de colisão do Raycast
        }                                 //Na rotação d objeto que recebe a colisão
    }
}
