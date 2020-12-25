using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{

    //Make sure game is not paused
    void Start()
    {
        Time.timeScale = 1;
    }

    public void LoadA(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
