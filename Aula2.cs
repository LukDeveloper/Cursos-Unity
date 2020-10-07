using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODA FUNÇÃO Personalizada DEVE SER PUBLICA PARA QUE SEJA VISÍVEL AO INSPECTOR///////////////////////////////////////////
public class Aula2 : MonoBehaviour
{
    public int numero;
    //Funções
    void Start() //Função executada no inicio do game, no primeiro flame do jogo, dps nunca mais é chamada
    {
        numero = 1;
        MorteDoPlayer(8); //Chamada da função personalizada e passagem de um numero como parametro, como exigido pela função
    }

    private void Awake() //Função executada antes de comecar o jogo, apenas uma vez
    {
        numero = 2;
    }

    void Update() //Função chamada a cada flame do jogo / inconstante, pode variar por conta do flame
    {             //Otima para trabalhar com imput's, teclas pressionadas durante a Game Scene
        if (Input.GetKeyDown("e"))
        {  //Verificação se a tecla "e" foi pressionada
            numero = numero++;
        }
        //X    Y   Z//
        transform.Translate(0.1f, 0, 0); //comando para mover objetos na cena (velocidade de movimento no eixo x, eixo y eixo z)
        transform.Translate(0.1f * Time.deltaTime, 0, 0); //adequar movimento a taxa de flames no jogo compilado
        transform.Translate(-2f * Time.deltaTime, 0, 0); //movimentando para o lado contrário
    }

    void FixedUpdate() //Funçao executada para uma taxa definida de flames // utilizada para RigidBody
    {                  //Não recomendado para input's e sim para setar valores com consistencia
        if (Input.GetKeyDown("e"))
        {  //Verificação se a tecla "e" foi pressionada
            numero = numero++;
        }
    }

    void LateUpdate() //Funçao executada apos a função Update
    {
        numero = numero++;
    }

    void OnTriggerEnter(Collider other) //Função executada quando um objeto entrar em um Trigger de outro objeto
    {                                   //Permite como parametros Tag's de outros objetos
        numero = 10;
    }

    void OnTriggerExit(Collider other) //Função executada quando um objeto sair de um Trigger de outro objeto
    {                                  //Permite como parametros Tag's de outros objetos    
        numero = 0;
    }

    void OnCollisionEnter(Collision other) //Função executada quando um objeto entrar em um Collider de outro objeto
    {
        numero = 20;
    }

    void OnCollisionExit(Collision other) //Função executada quando um objeto sair de um Collider de outro objeto
    {
        numero = 0;
    }

    void OnMouseEnter() //Função executada quando o cursor passar sobre o objeto
    {
        numero = 40;
    }

    void OnMouseExit() //Função executada quando o cursor sair do objeto
    {
        numero = 40;
    }

    //funções personalizadas
    public void MorteDoPlayer(int numero2) //Função será executada quando for chamada, por isso deve ser chamada em alguma outra função
    {                               //Ela recebe a variável numero2 como parametro e vai coloca-lo na variável numero
        numero = numero2;
    }

    public void PerderVida(int QuantoDescontar)
    {
        Debug.Log("perder " + QuantoDescontar + " de Vida");    //Mostra a mensagem e o valor da variavel concatenada e setada ao chamar da função
    }
}
