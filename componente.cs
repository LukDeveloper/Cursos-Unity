using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componente : MonoBehaviour
{
    public GameObject cameraplayer;
    private AudioSource audioS;
    public float rangePitch = 1;

    private Light luz;

    private Rigidbody corpoRigido;

    private MeshRenderer renderer;

    void Start()
    {
        GetComponent<AudioSource>().enabled = false; //alterar o componente do objeto que está com o script
        cameraplayer.GetComponent<Camera>().enabled = false; //alterar o componente de outro objeto
        audioS = GetComponent<AudioSource>(); //Transformando uma variável em um acesso rapido ao componente desejado
        audioS.loop = true; //utilizando a variavel para acessar diretamente o componente e configura-lo

        // var veiculocomponente = GetComponent<Veiculo>();
        // veiculocomponente.marchasAutomaticas = true;

        luz.GetComponent<Light>();   //Transformando uma variável em um acesso rapido ao componente desejado

        corpoRigido.GetComponent<Rigidbody>();   //Transformando uma variável em um acesso rapido ao componente desejado

        renderer.GetComponent<MeshRenderer>();   //Transformando uma variável em um acesso rapido ao componente desejado
    }

    void Update()
    {
        audioS.pitch = rangePitch;  //utilizando a variavel para acessar diretamente o componente e configura-lo
        if (Input.GetKeyDown(KeyCode.F))
        {
            luz.enabled = !luz.enabled; //Recebe o contrário dela   (true / false)
            corpoRigido.isKinematic = !corpoRigido.isKinematic; //Recebe o contrário dela (true / false)
            renderer.enabled = !renderer.enabled;   //Recebe o contrário dela (true / false)
        }
    }
}
