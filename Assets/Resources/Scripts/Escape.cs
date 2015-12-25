using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour {

    private void EscapeOn()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject.Find("script_Score").SendMessage("StopTimeFlows");
        GameObject.Find("script_Clear").SendMessage("ClearOn");
        GameObject.Find("Present").SetActive(false);
    }
}
