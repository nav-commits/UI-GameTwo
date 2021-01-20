using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneload : MonoBehaviour
{
    public void Loadscene()
    {

        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);

    }


    public void Loadstart()
    {
        SceneManager.LoadScene(0);
    }



    public void QuitGame()
    {
        Application.Quit();

    }
}








