using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class structAula : MonoBehaviour
{
    //Struct pode ser utilizada automatizar a criação de atributos compostos, Vector's personalizados, serie de variáveis e etc

    public struct structUsuario
    {        //Declarando uma Struct

        public string nomeUsuario;

        public int vidaUsuario;

        public int danoUsuario;
    }

    public structUsuario usuario1, usuario2;      //Declarando instancias que utilização da struct

    struct Vector6
    {                             //Struct é feita para trabalhar com valores imutáveis
        public float x;
        public float y;
        public float z;
        public float w;
        public float a;
        public float d;

        public Vector6(float fx, float fy, float fz, float fw, float fa, float fd)
        {    //Utilizando um construtor para acessar a struct que esta privada
            this.x = fx;
            this.y = fy;
            this.z = fz;
            this.w = fw;
            this.a = fa;
            this.d = fd;
        }
    }

    void Start()
    {
        usuario1.nomeUsuario = "marcos";      //Setando valores na Struct
        usuario1.vidaUsuario = 100;
        usuario1.danoUsuario = 100;

        usuario2.nomeUsuario = "martin";      //Setando valores na Struct
        usuario2.vidaUsuario = 50;
        usuario2.danoUsuario = 50;

        Debug.Log(usuario1.vidaUsuario);        //Apresentando valores contidos na struct, acessando seus atributos
        Debug.Log(usuario2.vidaUsuario);

        Vector6 vetor = new Vector6(1, 2, 3, 4, 5, 6);

        Debug.Log(vetor.w);
    }
}
