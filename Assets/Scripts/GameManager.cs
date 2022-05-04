using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using System.Collections;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded= false;
    public float restartDelay=1f;
    public GameObject completeLevelUI;
    public Text countText;
    public int scoreValue;
    public float animationDuration=0.001f;

    public void Start(){
        
        countText.text = PlayerPrefs.GetInt("score", scoreValue).ToString();
        
    }
    
    public void scorePlus(){
        
        scoreValue=PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("score",scoreValue+1);
        scoreValue=PlayerPrefs.GetInt("score");
        countText.text = scoreValue.ToString();
        /* for(int i=0; i<10; i++){
            Invoke("scoreIn", 0.5f);
        }
        for(int i=0; i<10; i++){
            Invoke("scoreDec", 0.5f);
        } */

            StartCoroutine(scoreIn());
    }

    IEnumerator scoreIn(){
        for(int i=0; i<17;i++){
        countText.fontSize=countText.fontSize+3;
        yield return new WaitForSeconds(animationDuration);
        }
        
        for(int i=0; i<17;i++){
        countText.fontSize=countText.fontSize-3;
        yield return new WaitForSeconds(animationDuration);
        }
    }

    

    public void CompleteLevel(){
        Debug.Log("Level Completed!");
        completeLevelUI.SetActive(true);
    }
    public void EndGame(){
        if(gameHasEnded==false){
            gameHasEnded=true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
