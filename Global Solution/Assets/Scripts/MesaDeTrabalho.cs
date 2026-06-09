using System;
using UnityEngine;

public class MesaDeTrabalho : MonoBehaviour
{
    
    private bool ConseguiConstruir = false;
    public bool PodeInteragir = false;
    [SerializeField] private Player Nimo;

    
    void Update()
    {
        
        ConstruirEspada();

    }

    public void ConstruirEspada()
    {

       if (Nimo.Interagiu == true)
        {
            
            if(Nimo.QuantidadedeMadeiras >= 13)
            {
                
                print("Você construiu uma Espada de Madeira.");
                Nimo.Espada = true;
                Nimo.QuantidadedeMadeiras -= 13;
                Nimo.Interagiu = false;

            }

            else
            {
                
                print("Quantidade de madeiras insuficiente você precisa pegar mais madeiras.");
                Nimo.Interagiu = false;

            }

        }     

    }

    void OnTriggerEnter2D(Collider2D Col)
    {
        
        if(Col.gameObject.tag == "Player")
        {
            
            PodeInteragir = true;

        }

    }

    void OnTriggerExit2D(Collider2D Col)
    {

        if(Col.gameObject.tag == "Player")
        {
            
            PodeInteragir = false;

        }
        
    }
}
