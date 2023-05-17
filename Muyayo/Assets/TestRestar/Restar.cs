using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restar : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestarLevel();
        }
    }
    void RestarLevel()
    {
        SceneManager.LoadScene(2);
    }
}
