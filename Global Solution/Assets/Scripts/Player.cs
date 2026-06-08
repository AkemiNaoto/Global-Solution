using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private Rigidbody2D Rig;

    private float Velocidade = 7.0f;

    void Update()
    {

        Mover();

    }

    public void Mover()
    {
        
        float Horizontal = Input.GetAxis("Horizontal") * Velocidade * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * Velocidade * Time.deltaTime;

        transform.Translate (Horizontal, Vertical, 0.0f);

    }

}
