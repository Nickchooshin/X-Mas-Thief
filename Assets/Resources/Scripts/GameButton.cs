using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour {

    public GameObject titlePanel;
    public GameObject gamePanel;
    public GameObject pausePanel;

    public GameObject script_Score;
    public GameObject script_Joystick;

    void Start()
    {
    }

    public void ClickStartButton()
    {
        titlePanel.SetActive(false);
        gamePanel.SetActive(true);

        script_Joystick.SendMessage("SetVisible", true);
        script_Score.SendMessage("StartTimeFlows");
    }

    public void ClickPauseButton()
    {
        Time.timeScale = 0.0f;
        pausePanel.SetActive(true);

        script_Joystick.SendMessage("SetVisible", false);
    }

    public void ClickResumeButton()
    {
        script_Joystick.SendMessage("SetVisible", true);

        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void ClickRestartButton()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel("sceneGame");
    }
}
