using UnityEngine;
using System.Collections;

public class Present : MonoBehaviour {

    public GameObject itemUI;
    public Transform uiPosition;

    void OnTriggerEnter2D(Collider2D collider)
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        itemUI.SetActive(true);
        transform.position = uiPosition.position;

        GameObject thiefObject = GameObject.Find("Thief_Prefab");
        GameObject escapeObject = GameObject.Find("Escape_Prefab");

        thiefObject.SendMessage("GetPresent");
        escapeObject.SendMessage("EscapeOn");
    }
}
