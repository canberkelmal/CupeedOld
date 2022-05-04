using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetHS : MonoBehaviour
{
    public Text HS;
    public GameObject NEW;

    void Start()
    {
        
        NEW.SetActive(false);
        if(PlayerPrefs.GetInt("HighScore")<PlayerPrefs.GetInt("score")){
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("score"));
        NEW.SetActive(true);
        }
        HS.text = PlayerPrefs.GetInt("HighScore").ToString();

    }
}
