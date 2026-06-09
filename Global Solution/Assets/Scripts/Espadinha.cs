using UnityEngine;

public class Espadinha : MonoBehaviour
{
    
   Player Nimo;

    void Start()
    {

        Nimo = GameObject.FindWithTag("Player").GetComponent<Player>();

    }

    void Update()
    {

        Invoke("Sumir", 1.5f);

    }

    public void Sumir()
    {

        Destroy(gameObject);
        Nimo.QuantidadeEspadas = 0;

    }

}
