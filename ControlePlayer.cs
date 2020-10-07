using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePlayer : MonoBehaviour
{
    public int A, B, result;    //Variaveis para metodo ResultadoSoma
    public bool condic1, condic2, tudoverdadeiro;
    public int ladoX, ladoY, altura, volume;    //Variaveis para metodo VolumeDoQuadrado
    public Aula codigo;    //declarando o construtor da classe
    public int receptor;   //variavel que irá receber outras advindas de outro script

    int ResultadoSoma(int valor1, int valor2)  //Metodo que retorna o resultado da soma de 2 parametros inteiros
    {
        return valor1 + valor2;
    }

    bool AmbasVerdadeiras(bool cond1, bool cond2)  //Metodo que retorna o resultado da soma de 2 parametros booleanos
    {
        if (cond1 == true && cond2 == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    int VolumeDoQuadrado(int ladoX, int ladoY, int altura)  //Metodo que retorna o resultado do calculo do volume de um quadrado, utilizando 3 parametros
    {
        return ladoX * ladoY * altura;
    }

    void Start()
    {
        int receberNumero = Aula.numero;   //utilizando variável estática declarada no outro script
        receptor = codigo.num;             //utilizando uma variavel publica de outro script      
    }
    void Update()
    {
        result = ResultadoSoma(A, B); //chamando o metodo e passando 2 variáveis como parametro a fim de atribuir o valor de retorno do metodo na variavel result
        volume = VolumeDoQuadrado(ladoX, ladoY, altura);  //chamando o metodo e passando 3 variáveis como parametro a fim de atribuir o valor de retorno do metodo na variavel volume
        tudoverdadeiro = AmbasVerdadeiras(condic1, condic2);    //chamando o metodo e passando 2 variáveis como parametro a fim de atribuir o valor de retorno do metodo na variavel tudoverdadeiro
    }
}
