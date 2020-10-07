using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;                       //Biblioteca necessaria para usar a Serialização da classe e ela se apresentar no inspector

namespace Teste                     //Como forma de organizar o codigo, pode ser usado o namespace, que transforma o trecho de codigo dentro dele em uma "biblioteca"
{

    [Serializable]                     //Serializando a classe para que ela se aprsente no inspector
    public class MinhaClasse{         //Criando uma classe
        public int varA;
        public float varB;
        public Vector3 varC;

        public void MultiplicarVarAPor10(){         //Criando um metodo
            varA = varA * 10;
        }

        public void MultiplicarValores(){         //Criando um metodo
            varA = varA * 10;
            varB = varB * 50;
        }
    }

    [Serializable]
    public class MinhaClasse1 : MinhaClasse{            //Criando relação de herança entre classes, MinhaClasse1 herda tudo da MinhaClasse
        public void MinhaVoid(){
            varA =5;                                    //Utilizando variaveis da classe herdada
            varB = 30;
        }
    }

    public class ClasseAula : MonoBehaviour     //Classe ClasseAula herdando da Classe MnoBehaviour
    {
        public MinhaClasse classe;              //Instanciando a "MinhaClasse" atraves do objeto "classe"
        public MinhaClasse1 classe1;            //Instanciando a "MinhaClasse1" atraves do objeto "classe1"
        public int somatorio;

        void Start()          //Metodos herdados da Classe MonoBehaviour
        {
            float somatorio = classe.varA + classe.varB;     //Somando variaveis de uma classe e setando nume outra variavel local
            classe.MultiplicarVarAPor10();                   //Chamando o metodo da classe "MinhaClasse"
        
            classe1.MinhaVoid();                             //Chamando o metodo da classe "MinhaClasse1"
            classe1.MultiplicarValores();                    //Chamando o metodo da classe "MinhaClasse" porem utilizando o objeto da "MinhaClasse1", acesso concedido graças a herança estabelecida entre elas
        }

        void Update()         //Metodos herdados da Classe MonoBehaviour
        {
            
        }
    }
}
