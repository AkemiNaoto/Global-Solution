using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform Player;
   
    void LateUpdate()
    {
        
        transform.position = new Vector3(Player.position.x, Player.position.y, 0.0f);

    }
}
