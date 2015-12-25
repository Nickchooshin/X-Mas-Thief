using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clear : MonoBehaviour {

    public GameObject clearPanel;
    public GameObject gamePanel;
    public Image presentBox;
    public Image present;
    public GameObject UI;

    private void ClearOn()
    {
        gamePanel.SetActive(false);
        clearPanel.SetActive(true);

        StartCoroutine("ClearPresent");
    }

    private IEnumerator ClearPresent()
    {
        Sprite[] presentSprite = Resources.LoadAll<Sprite>("Images/PresentList");
        int num = Random.Range(1, presentSprite.Length + 1);

        present.sprite = presentSprite[num];

        float startTime = Time.time;

        while (true)
        {
            float time = Time.time - startTime;
            float percent = (time / 3.0f);

            presentBox.color = new Color(1.0f, 1.0f, 1.0f, 1.0f - percent);
            present.color = new Color(1.0f, 1.0f, 1.0f, percent);

            if (time >= 3.0f)
            {
                presentBox.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
                present.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
                UI.SetActive(true);
                break;
            }

            yield return null;
        }
    }
}
