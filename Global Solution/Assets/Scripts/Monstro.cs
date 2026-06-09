using System.Collections;
using UnityEngine;

public class Monstro : MonoBehaviour
{
    
    [SerializeField] private Transform Alvo, Eu;
    [SerializeField] private Player Nimo;
    //[SerializeField] private Espadinha Espada;
    private int Velocidade = 4;
    [SerializeField] private int Vida = 100;

    void Start()
    {
        
        Alvo = GameObject.FindWithTag("Player").GetComponent<Transform>();
        Eu = GameObject.FindWithTag("Monstro").GetComponent<Transform>();
        Nimo = GameObject.FindWithTag("Player").GetComponent<Player>();
        //Espada = GameObject.FindWithTag("Espadinha").GetComponent<Espadinha>();

    }

    void Update()
    {
        
        Seguir();
        SistemadeVida();

    }

    public void Seguir()
    {
        
        if(Eu.position.x < Alvo.position.x)
        {
            
            transform.Translate(1.0f * Velocidade * Time.deltaTime, 0.0f, 0.0f);

        }

        if(Eu.position.x > Alvo.position.x)
        {
            
            transform.Translate(-1.0f * Velocidade * Time.deltaTime, 0.0f, 0.0f);

        }

        if(Eu.position.y < Alvo.position.y)
        {
            
            transform.Translate(0.0f, 1.0f * Velocidade * Time.deltaTime, 0.0f);

        }

        if(Eu.position.y > Alvo.position.y)
        {
            
            transform.Translate(0.0f, -1.0f * Velocidade * Time.deltaTime, 0.0f);

        }

    }

    void OnCollisionEnter2D(Collision2D Col)
    {
        
        if(Col.gameObject.tag == "Player")
        {
            
            print("Toquei Nimo");
            Nimo.Vida -= 10;

        }

        if(Col.gameObject.tag == "Espadinha")
        {
            
            print("Toquei Espada");
            Vida -= 25;

        }

    }

    public void SistemadeVida()
    {
        
        if(Vida <= 0)
        {
            
            Destroy(gameObject);            
            
        }

    }

}
