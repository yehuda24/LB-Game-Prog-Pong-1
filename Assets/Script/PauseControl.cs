using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{
    public GameObject PausePanel;

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

   public void ExitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
