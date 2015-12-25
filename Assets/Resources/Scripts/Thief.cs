using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Thief : MonoBehaviour {

    public float speed = 2.0f;

    void Update()
    {
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(h * speed * Time.deltaTime, v * speed * Time.deltaTime);
        transform.position += moveVector;

        Debug.Log(h + v);
    }
}
