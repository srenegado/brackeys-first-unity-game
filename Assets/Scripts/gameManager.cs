using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game over!");
            Invoke("Restart", restartDelay);
        }        
    }

    public void Restart()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
