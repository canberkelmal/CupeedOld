
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public GameObject HS;
    
    public GameObject NEW;
    public void Quit(){
        Debug.Log("Quit!");
        Application.Quit();

    }

    public void playAgain(){
        Debug.Log("Play Again!");
        SceneManager.LoadScene("Menu");
    }

    public void resetHS(){
        HS=GameObject.Find("HighScoree");
        NEW=GameObject.Find("NEW");
        Debug.Log("Reset High Score!");
        PlayerPrefs.SetInt("HighScore",0);
        HS.GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        NEW.SetActive(false);
    }
}
