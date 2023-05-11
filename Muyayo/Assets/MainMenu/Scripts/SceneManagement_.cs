using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement_ : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void RestarGame(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
    public void NextScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
