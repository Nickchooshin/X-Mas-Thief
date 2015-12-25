using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JoystickVisible : MonoBehaviour {

    public Image joystickImage;

    private void SetVisible(bool isVisible)
    {
        joystickImage.enabled = isVisible;
    }
}
