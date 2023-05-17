using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneManagement_ : MonoBehaviour
{
    public void NextScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
