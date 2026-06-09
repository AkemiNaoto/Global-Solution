using UnityEngine;

public class Monstro : MonoBehaviour
{
    
    [SerializeField] private Transform Alvo, Eu;
    private int Velocidade = 4;
    void Start()
    {
        
        Alvo = GameObject.FindWithTag("Player").GetComponent<Transform>();
        Eu = GameObject.FindWithTag("Monstro").GetComponent<Transform>();

    }

    
    void Update()
    {
        
        Seguir();

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
}
