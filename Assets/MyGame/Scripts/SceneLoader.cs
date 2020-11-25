using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    /*enum Scenes { WelcomeScene, MainScene, FinishScene };

    public void LoadNextScene()
    {
        SceneManager.LoadScene((int)Scenes.MainScene);
    }

    */

    public void LoadScene1()
    {
        SceneManager.LoadScene("WelcomeScene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("FinishScene");
    }
}
