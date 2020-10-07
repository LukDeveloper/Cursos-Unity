using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula : MonoBehaviour
{
    //PARA QUE QUALQUER VARIÁVEL FIQUE VISIVEL NA UNITY, É NECESSÁRIO NOMEA-LA COMO "public"
    public int num, num2, result;
    public float meio = 1.50f;  // necessário o "f" para a unity entender // 6 numeros dps da virgula
    public double comv = 1.30;  // Suporta até 16 numeros apos a virgula
    public string letra;
    public Vector3 vetor3Dimenssion;            // vetor tridimensional de 3 valores
    public Vector2 vetor2Dimenssion;            // vetor tridimensional de 3 valores

    //  A UNITY PERMITE DECLARAR TODOS SEUS COMPONENTES COMO SE FOSSEM VARIAVEIS
    public GameObject objeto;
    public Texture textura;
    public ControlePlayer controle;

    // Variavel que será acessada por todo e qualquer script **Variavel Estática**
    public static int numero;

    //função chamada uma unica vez, no inicio do game
    void Start()
    {
        Camera cam = GetComponent<Camera>();  //A variavel cam recebe o componente camera
        result = num + num2;
    }

    // Acontece o Tempo todo
    void Update()
    {
        RaycastHit PontoDeColisao;  //exemplo de variaveis locais/ Temporárias
    }

    //Função teste
    void ControlarVida()
    {

    }

    //metodo de checagem de colisão
    private void OnTriggerEnter(Collider other) {
        
    }

    //criar botões na tela
    private void OnGUI() {
        
    }
}
