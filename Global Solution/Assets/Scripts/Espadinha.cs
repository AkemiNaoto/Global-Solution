using UnityEngine;

public class Espadinha : MonoBehaviour
{
    
   Player Nimo;
   public int Dano = 25;

    void Start()
    {

        Nimo = GameObject.FindWithTag("Player").GetComponent<Player>();

    }

    void Update()
    {

        Invoke("Sumir", 0.5f);

    }

    public void Sumir()
    {

        Destroy(gameObject);
        Nimo.QuantidadeEspadas = 0;

    }

}
