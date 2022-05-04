using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Count : MonoBehaviour
{
    public Transform Player;
    public Text posText;
    void Update()
    {
        posText.text="x: "+ Player.position.x.ToString("0")+ "| y: "+Player.position.y.ToString("0")+"| z: "+Player.position.z.ToString("0");

    }
}
