using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpAula : MonoBehaviour
{
    // lerp só funciona bem no update ///////////////////////

    private bool ativarPitch = false;  //Gatilho para modificar o pitch do audio

    public Vector3 rotacFinal;  //Posição de destino do objeto

    public GameObject obj;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(5, 5, 5), Time.deltaTime); //Movimentar objeto até ponto determinado no mundo de forma suave
                                                                                                     //posição atual       posição desejada    velocidade de tranzição

        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, rotacFinal, Time.deltaTime); //Rotacionar o objeto até a posição desejada
                                                                                                 //posição atual       posição desejada

        transform.rotation = Quaternion.Lerp(transform.rotation, obj.transform.rotation, Time.deltaTime); //Rotacionar o objeto até a posição do outro objeto

        if (Input.GetKeyDown(KeyCode.F))
        {
            ativarPitch = true;
        }
        if (ativarPitch == true)
        {
            GetComponent<AudioSource>().pitch = Mathf.Lerp(GetComponent<AudioSource>().pitch, 3, Time.deltaTime); //Simulando Aceleração(*Audio*) ao movimentar o objeto até seu destino
        }

        transform.localScale = new Vector3(Mathf.Lerp(transform.localScale.x, 5, Time.deltaTime), 5, 5); //Dimencionar objeto diretamente no eixo Y e Z e devagar no eixo X suavemente
    }
}
