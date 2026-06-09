using UnityEngine;

public class stars : MonoBehaviour
{
    public float velocidade = 0.05f;

    void Update()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);

        // Se passar de x = 9, volta para x = -9.5
        if (transform.position.x > 9f)
        {
            transform.position = new Vector3(
                -9f,
                transform.position.y,
                transform.position.z
            );
        }
    }
}