using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enumAula : MonoBehaviour
{
    public enum Opcoes
    {   //Construindo o enum, que é uma caixa de opções no inspector
        opcao1,
        opcao2,
        opcao3
    };

    public Opcoes selecione = Opcoes.opcao3;  //Declarando o enum construido e iniciando com a opção desejada previamente selecionada

    //public Opcoes selecione;//Declarando o enum construido

    public enum Estado
    {
        EmJogo,
        Pausado
    };

    public Estado estadoDoJogo;

    bool pausa = false;

    public enum EstadoAI
    {
        Seguir,
        Olhar
    };

    public EstadoAI Bot;
    bool estadoDaAI = false;

    public Transform alvo;

    void Start()
    {

    }

    void Update()
    {
        switch (selecione)
        {
            case Opcoes.opcao1:   //Caso a opcao1 esteja selecionada faça...
                transform.Translate(50 * Time.deltaTime, 0, 0);   //Movimentar o objeto no eixo X
                break; //Saindo do switch

            case Opcoes.opcao2:    //Caso a opcao2 esteja selecionada faça...
                transform.Translate(-50 * Time.deltaTime, 0, 0);   //Movimentar o objeto no eixo X
                break;

            case Opcoes.opcao3:     //Caso a opcao3 esteja selecionada faça...
                transform.Translate(500 * Time.deltaTime, 0, 0);   //Movimentar o objeto no eixo X
                break;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {   //Ao pressionar a tecla "p"

            pausa = !pausa;  //A variavel pausado que esta como false recebe o inverso dela, true

            if (pausa == true)
            {      //Se pausado for igual a true
                estadoDoJogo = Estado.Pausado; //O enum estadoDoJogo seleciona a opção Pausado
            }
            else
            {
                estadoDoJogo = Estado.EmJogo;   //O enum estadoDoJogo seleciona a opção EmJogo
            }
        }

        switch (estadoDoJogo)
        {
            case Estado.EmJogo:
                Time.timeScale = 1;     //Time.timeScale condiz com a escala em que o jogo é renderizado, onde 1 ele corre normalmente e 0 ele pausa
                break;

            case Estado.Pausado:
                Time.timeScale = 0;
                break;
        }
        // Mini IA /////////////
        if (Input.GetKeyDown(KeyCode.D))
        {   //Ao pressionar a tecla "D"

            estadoDaAI = !estadoDaAI;       //A booleana estadoDaAI recebe o inverso do seu valor atual

            if (estadoDaAI == true)
            {         //Se estadoDoAI for igual a true...
                Bot = EstadoAI.Seguir;
            }
            else
            {                          //Se não...
                Bot = EstadoAI.Olhar;
            }
        }

        switch (Bot)
        {                        //Selecionado o enum no qual o switch varrerá
            case EstadoAI.Seguir:
                transform.position = Vector3.Lerp(transform.position, alvo.transform.position, Time.deltaTime * 0.5f);  //Movimentar o detentor do script de modo que ele siga o objeto alvo   
                break;                      //ATENÇÂO!! necessário o break

            case EstadoAI.Olhar:
                transform.LookAt(alvo);     //Olhar para o objeto setado como alvo
                break;
        }
    }
}
