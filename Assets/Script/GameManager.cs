using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int ScoreLeft;
    public int ScoreRight;
    
    public TMP_Text LeftScoreUI;
    public TMP_Text RightScoreUI;
    public static GameManager Instance;
    public SceneManagement sceneManagement;

    public TMP_Text WinTextCondUI;
    public GameObject WinOrLoseUI;

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Scoring(string wallName)
    {
        if (wallName == "RightWall")
        {
            ScoreLeft = ScoreLeft + 10;
            LeftScoreUI.text = ScoreLeft.ToString();
            WinFound();
        } else
        {
            ScoreRight = ScoreRight + 10;
            RightScoreUI.text = ScoreRight.ToString(); 
            WinFound();
        }
    }

    private void Delay()
    {
        sceneManagement.SceneChange("Menu");
    }
    private void WinText()
    {
        if (ScoreLeft == 30)
        {
            WinTextCondUI.text = "Wizard Won";
        } else if(ScoreRight == 30) {
            WinTextCondUI.text = "Bear Won";
        }
    }
    private void WinFound()
    {
        if(ScoreLeft == 30) {
            WinOrLoseUI.SetActive(true);
            Invoke("WinText", 0.2f);
            Invoke("Delay", 0.4f);
        }
        else if(ScoreRight == 30)
        {
            WinOrLoseUI.SetActive(true);
            Invoke("WinText", 0.2f);
            Invoke("Delay", 0.4f);
        }
    }

}
