using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotat : MonoBehaviour
{
    public Vector3 rotacao1;
    public Quaternion quat;

    public Vector3 rotacao2, rotacao3, rotacao4;

    public float angulo;

    public GameObject objetoTeste, objetoTeste2;

    void Update()
    {
        // eulerAngles utiliza-se do sentido anti-Horário para trabalhar com posições, já o rotation não adota esse critério
        transform.eulerAngles = new Vector3(45, 0, 0);
        transform.rotation = Quaternion.Euler(rotacao1);  //Para utilizar o rotation e necessário um Quaternion, por isso é convertido o Vecto3 em um
                                                          //utilizando o Euler

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotacao1), Time.deltaTime); //rotacionar suavemente até a posição setada

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotacao1), Time.deltaTime); // Slerp Trabalha com taxa de flames igualada

        transform.rotation = Quaternion.identity; //Sempre se posicionar na localização 0,0,0 do mundo

        angulo = Quaternion.Angle(Quaternion.Euler(rotacao2), Quaternion.Euler(rotacao3)); //Calculando a diferença angular

        //setando valores no quaternion
        quat[0] = 0.1f; //setou valor no X
        quat[0] = 0.2f; //setou valor no Y
        quat[0] = 0.3f; //setou valor no Z
        quat[0] = 0.4f; //setou valor no W

        quat.Set(0, 0, 0, 4); //setou valor no W

        quat.Set(quat.x, quat.y, 0.1f, quat.w); //setando valor e mantendo os demais

        transform.rotation = Quaternion.AngleAxis(30, Vector3.forward); //Girar 30 graus no eixo Z
                                                                        //frente
        transform.rotation = Quaternion.AngleAxis(30, Vector3.up); //Girar 30 graus no eixo Y
                                                                   //cima
        transform.rotation = Quaternion.Inverse(objetoTeste.transform.rotation); // Rotação inversa a do objeto referenciado

        transform.rotation = Quaternion.LerpUnclamped(transform.rotation, Quaternion.Euler(rotacao4), Time.deltaTime); //Lerp normalizado, rotação suave normalizada

        transform.rotation = Quaternion.RotateTowards(transform.rotation, objetoTeste2.transform.rotation, Time.deltaTime * 5); //Copiar a rotação do outro objeto setado
    }
}
