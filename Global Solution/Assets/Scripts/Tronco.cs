using Unity.VisualScripting;
using UnityEngine;

public class Tronco : MonoBehaviour
{
    
    public bool PoderPegar = false;

    
    public void OnTriggerEnter2D(Collider2D Col)
    {
            

            if (Col.gameObject.tag == "Player")
            {

                PoderPegar = true;

            }

    }

    public void OnTriggerExit2D(Collider2D Col)
    {

        if (Col.gameObject.tag == "Player")
        {
            
            PoderPegar = false;

        }

    }


}
