using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour {

    public GameObject titlePanel;
    public GameObject gamePanel;
    public GameObject pausePanel;

    public void ClickStartButton()
    {
        titlePanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void ClickPauseButton()
    {
        Time.timeScale = 0.0f;
        pausePanel.SetActive(true);
    }

    public void ClickResumeButton()
    {
        Time.timeScale = 1.0f;
        pausePanel.SetActive(false);
    }

    public void ClickRestartButton()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel("sceneGame");
    }
}
