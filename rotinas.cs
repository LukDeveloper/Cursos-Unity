using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotinas : MonoBehaviour
{
    //ROTINAS///////////////
    public bool condicao = false;
    public bool podeAtirar;
    public GameObject bala;
    public float tempoespera = 0.4f;

    void Start()
    {
        StartCoroutine("Rotina"); //Deve startar a Rotina, diferentemente do chamar um metodo
        podeAtirar = true;

        Time.timeScale = 0.5f;  //Tempo de execução das cenas

        Debug.Log(Time.time); //Tempo de jogo;

        StartCoroutine("Esperar2Seg"); //Chamando o IEnumerator que mostrara tempo de jogo 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && podeAtirar == true)
        {
            GameObject objeto = Instantiate(bala, transform.position, transform.rotation) as GameObject;
            //(objeto criado, posiçao do detentor do script, pra frente do detentor do script)
            objeto.GetComponent<Rigidbody>().AddForce(Vector3.forward * 3000); //Adicionando uma force para lançar o objeto criado
                                                                               //para frente do objeto com script
            StartCoroutine(DeixarVerdadeira(tempoespera));
        }         //não esta entre aspas porque esta passando parametros
    }

    IEnumerator Rotina()
    {
        yield return new WaitForSeconds(2.0f);  //Esperar por segundos, 2 segundos neste caso
        condicao = true; //Setar true apos a espera
    }

    IEnumerator DeixarVerdadeira(float tempoEsperando)
    {
        yield return new WaitForSeconds(tempoEsperando);   //Esperar por segundos advindos a da variável que chega por parametro
        podeAtirar = true;
    }

    IEnumerator Esperar2Seg()
    {
        yield return new WaitForSeconds(2.0f); //Esperar por 2 segundos
        Debug.Log(Time.time); //Mostrar o tempo de jogo
    }
}
