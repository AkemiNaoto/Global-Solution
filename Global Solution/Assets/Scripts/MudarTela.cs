using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarTela : MonoBehaviour
{
    
    Scene CenaAtual;

    void Update()
    {
        
        if(Input.anyKeyDown)
        {

            SceneManager.LoadScene("Game");

        }

    }
}
