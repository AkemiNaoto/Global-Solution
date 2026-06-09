using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform Player;
   
    void LateUpdate()
    {
        
        if (Player != null)
        {

        transform.position = new Vector3(Player.position.x, Player.position.y, -10.0f);

        }

    }
}
