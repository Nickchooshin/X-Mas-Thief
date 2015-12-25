using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

    void Start()
    {
        Screen.fullScreen = false;
        Screen.SetResolution(1280, 720, false);
    }
}
