using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    
    public void Death()
    {
        if (gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("Dead");
            Invoke("DeathMenu", 0);
        }
    }

    public void DeathMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
