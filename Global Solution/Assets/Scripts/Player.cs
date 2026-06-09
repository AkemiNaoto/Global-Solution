using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private Rigidbody2D Rig;
    [SerializeField] private Tronco Madeira;
    [SerializeField] private MesaDeTrabalho Minecraft;
    public bool Interagiu = false;
    public int QuantidadedeMadeiras;
    public int QuantidadeEspadas;
    private GameObject Espadinha;
    [SerializeField] private Transform Nimo;
    private float Velocidade = 7.0f;
    public bool Espada = false;
    public GameObject EspadaDeMadeira;

    void Start()
    {
        
        QuantidadedeMadeiras = 0;

    }

    void Update()
    {

        Mover();
        PegarMadeira();
        Interagir();
        Atacar();

    }

    public void Mover()
    {
        
        float Horizontal = Input.GetAxis("Horizontal") * Velocidade * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * Velocidade * Time.deltaTime;

        transform.Translate (Horizontal, Vertical, 0.0f);

    }

    public void PegarMadeira()
    {

        if(Input.GetButtonDown("Jump"))
        {


            if (Madeira.PoderPegar == true)
            {
                
                QuantidadedeMadeiras++;
                print("Você pegou uma madeira sua quantidade de madeiras atuais é " + QuantidadedeMadeiras + " madeiras.");

            }

        }

    }

    public void Interagir()
    {
        
        if(Input.GetButtonDown("Jump"))
        {

        if (Minecraft.PodeInteragir == true)
        {
            
            Interagiu = true;

        }

        else
        {
            
            Interagiu = false;

        }

        }

    }

    public void Atacar()
    {
        
        if(Espada == true)
        {
            
            if(Input.GetButtonDown("Fire1"))
            {
                
                StartCoroutine(Atacou());
                

            }

        }

    }

    IEnumerator Atacou()
    {
        
        if(QuantidadeEspadas == 0)
        {
        Instantiate(EspadaDeMadeira);
        Espadinha = GameObject.FindWithTag("Espadinha");
        Espadinha.transform.position = new Vector3(Nimo.position.x + 1.90f, Nimo.position.y, Nimo.position.z);
        print("Atacou");
        QuantidadeEspadas++;
        }

        yield return new WaitForSeconds(3.0f);

        
    }

}
