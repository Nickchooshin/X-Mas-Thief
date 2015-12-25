using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Detection : MonoBehaviour {

    public Image DetectionGauge;
    public float detectionSpeed = 1.0f; // 직진 러닝시 게이지가 풀로 차게 될 시간
    public float detectionDecreaseSpeed = 10.0f; // 풀 기준으로 가만히 있을 시 완전히 감소되는 시간

    public GameObject failPanel;
    public GameObject gamePanel;

    public GameObject script_Joystick;

    private bool m_isDetection = false;

    void Start()
    {
        DetectionGauge.fillAmount = 0.0f;

        StartCoroutine("MoveDetection");
        StartCoroutine("DetectionDecrease");
    }

    private IEnumerator MoveDetection()
    {
        while (true)
        {
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
            float f = 0.0f;

            if (h < 0.0f)
                h = -h;
            if (v < 0.0f)
                v = -v;
            f = h + v;

            DetectionGauge.fillAmount += (f / detectionSpeed) * Time.deltaTime;

            if (DetectionGauge.fillAmount >= 1.0f)
            {
                gamePanel.SetActive(false);
                failPanel.SetActive(true);

                script_Joystick.SendMessage("SetVisible", false);
                break;
            }

            yield return null;
        }
    }

    IEnumerator DetectionDecrease()
    {
        while (true)
        {
            DetectionGauge.fillAmount -= (1.0f / detectionDecreaseSpeed) * Time.deltaTime;

            yield return null;
        }
    }
}
