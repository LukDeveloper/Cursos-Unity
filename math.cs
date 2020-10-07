using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math : MonoBehaviour
{
    public float valor;
    void Start()
    {
        valor = Input.GetAxis("Horizontal"); //Valor irá receber Input's na horizontal
        valor = Mathf.Abs(Input.GetAxis("Horizontal")); //Converçao do input para um numero positivo
        valor = Mathf.Abs(-50.5f);  //Converçao do input para um numero positivo ou seja 50.5
        valor = Mathf.Clamp(Input.GetAxis("Horizontal"), -0.5f, 0.5f); //Trabalhar entre dois intervalos, min e max
                                                                       //(Recebendo input, valor minimo, valor maximo)
        valor = Mathf.Clamp01(Input.GetAxis("Horizontal")); //Trabalhar entre dois intervalos, min 0 e max 1
        valor = Mathf.Sign(Input.GetAxis("Horizontal"));    //Trabalhar entre dois intervalos, 1 se for maior ou igual a 0 e se for menor, retorna -1
        valor = Mathf.DeltaAngle(1080, 90); //Conferindo o menor angulo entre os dois setados
        valor = (int)Input.GetAxis("Horizontal"); //Convertendo o valor para inteiro
        valor = Mathf.Floor(Input.GetAxis("Horizontal")); //Convertendo o valor para inteiro mais aproximada
        valor = Mathf.Round(Input.GetAxis("Horizontal")); //Convertendo o valor para inteiro arredondada
        valor = Mathf.Lerp(valor, 5.0f, Time.deltaTime * 0.2f); //Aproximar do valor 5.0 devagar
                                                                //(valor de inicio, valor a ser atingido, valocidade)
        transform.position = new Vector3(valor, 0, 0); //movimentar objeto

        valor = Mathf.LerpUnclamped(valor, 5.0f, Time.deltaTime * 0.2f); //Aproximar do valor 5.0 devagar linearmente
        valor = Mathf.MoveTowards(valor, 5.0f, Time.deltaTime * 0.2f); //Aproximar do valor 5.0 com velocidade constante
        valor = Mathf.Max(10, 5); //Retorna o maior valor, 10 no caso
        valor = Mathf.Min(10, 5); //Retorna o menor valor, 5 no caso

        if (Mathf.Approximately(10.0f, 100.0f / 100.0f))
        { //Comparando valores

        }
        valor = Mathf.Sqrt(25); //Raiz quadrada de 25
        valor = Mathf.Pow(5, 3); //numero 5 e seu expoente 3, potenciação
        valor = Mathf.PingPong(Time.time, 5); // Valor vai até 5 e volta até 0
        transform.position = new Vector3(valor, 0, 0); //Objeto indo até um ponto e voltando ao ponto de inicio

        valor = Mathf.Repeat(Time.time, 5); //Objeto indo até um ponto repetidamente
        valor = Mathf.PI; //Retorna o valor de PI
        valor = Mathf.Infinity; //Trabalhando com o valor infinito, para tornar algo inquebravel
        valor = Mathf.NegativeInfinity; //Trabalhando com o valor infinito negativo
        valor = Mathf.Epsilon; //O menor valor próximo de 0
        valor = Mathf.Rad2Deg * 1; //Converter 1 radianos para graus
        valor = Mathf.Deg2Rad * 57; //Converter 57 graus para radianos
    }
}
