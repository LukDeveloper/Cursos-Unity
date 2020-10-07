using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transf : MonoBehaviour
{
    public Transform camera;

    void Update()  //TRANSLATE, ROTATE SÃO PROPRIEDADES PARA SEREM APLICADAS EM OBJETOS QUE SEJAM ESTÁTICOS, QUE NÃO CONTENHAM FISICA
    {
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(1 * Time.deltaTime, 0, 0); //1 segundo dividido pelo numero de flames do jogo  //GIRAR OBJETO
        }
        Debug.Log(Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * Time.deltaTime, 0, 0); //1 segundo dividido pelo numero de flames do jogo   //MOVER OBJETO
        }

        if (Input.GetKey(KeyCode.B))
        {
            transform.eulerAngles = new Vector3(45, 45, 45); //Rotacionar o objeto para o angulo desejado
        }

        if (Input.GetKey(KeyCode.E))
        {
            Vector3 rotacaofinal = new Vector3(45, 45, 45);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * 5);  //Rotacionar suave do objeto para o angulo desejado
        }                                                            //posição 0,0,0    //aumentar velocidade "*5"

        if (Input.GetKey(KeyCode.T))
        {
            transform.localEulerAngles = new Vector3(3, 3, 3); //Utilizar o ambiente do objeto pai e não o do mundo
        }

        if (Input.GetKey(KeyCode.G))
        {
            transform.localScale = new Vector3(3, 3, 3); //Utilizar o ambiente do objeto pai e não o do mundo, alterando a escala do objeto
        }

        if (Input.GetKey(KeyCode.P))
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(3, 3, 3), Time.deltaTime); //Utilizar o ambiente do objeto pai e não o do mundo, alterando a escala do objeto suavemente
        }

        if (Input.GetKey(KeyCode.P))
        {
            transform.LookAt(Vector3.zero); //utiliza-se para que o objeto olhe para um ponto determinado no mundo
        }                   //ponto zero no mundo "0,0,0"

        transform.LookAt(camera); //utilizou-se para que o objeto olhe para o objeto camera no mundo
        transform.Translate(-5 * Time.deltaTime, 0, 0); //utilizou-se para que o objeto rotacione sobre a camera
    }
}
