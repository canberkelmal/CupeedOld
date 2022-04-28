using UnityEngine;
using UnityEngine.UI;

public class Color : MonoBehaviour
{
    public GameObject Player;
    public Text posText;
    void Update()
    {
        Player=GameObject.Find("Player");
        posText.color = Player.GetComponent<Renderer>().material.GetColor("_Color");

    }
}
