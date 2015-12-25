using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text timeText;

    private float m_startTime;

    void Start()
    {
        m_startTime = Time.time;

        StartCoroutine("TimeFlows");
    }

    IEnumerator TimeFlows()
    {
        while (true)
        {
            int time = (int)((Time.time - m_startTime) * 100.0f);
            int minutes, seconds;

            minutes = time / 6000;
            time = time % 6000;
            seconds = time / 100;
            time = time % 100;

            timeText.text = minutes.ToString("D2") + ":" + seconds.ToString("D2") + ":" + time.ToString("D2");

            yield return null;
        }
    }
}
