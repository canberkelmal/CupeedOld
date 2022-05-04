using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    
    public PlaayerMovement force;
    
    public GameObject box=GameObject.Find("box");
    public GameObject box1=GameObject.Find("box (1)");
    public GameObject box2= GameObject.Find("box (2)");
    public GameObject plane= GameObject.Find("Plane");
    public GameObject plane2= GameObject.Find("Plane (2)");
    public GameObject speed=GameObject.Find("speed");
    public GameManager gameManager;
    public float animationDuration=0.001f;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision ColInf){
        
        FindObjectOfType<AudioManager>().Play("PlayerHit");
        if(ColInf.collider.name!="Plane"){
            if (GetComponent<Renderer>().material.color != ColInf.collider.GetComponent<Renderer>().material.GetColor("_Color")){
                StartCoroutine(speedChng());
                
            }
            Debug.Log("Collision! " + ColInf.collider.name);
            gameManager.scorePlus();
            GetComponent<Renderer>().material.color = ColInf.collider.GetComponent<Renderer>().material.GetColor("_Color");

            /* for(int i=count.GetComponent<UnityEngine.UI.Text>().fontSize; i<count.GetComponent<UnityEngine.UI.Text>().fontSize+10; i++){
                count.GetComponent<UnityEngine.UI.Text>().fontSize=i;
            }
            for(int i=count.GetComponent<UnityEngine.UI.Text>().fontSize+10; i>=count.GetComponent<UnityEngine.UI.Text>().fontSize; i++){
                count.GetComponent<UnityEngine.UI.Text>().fontSize=i;
            } */
        }
        if(GetComponent<Renderer>().material.color==box.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=25;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();
        //StartCoroutine(speedChng());
        }
        if(GetComponent<Renderer>().material.color==box1.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=10;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();
        //StartCoroutine(speedChng());
        }
        if(GetComponent<Renderer>().material.color==box2.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=15;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();
        //StartCoroutine(speedChng());
        //FindObjectOfType<GameManager>().EndGame();
        }
        if(GetComponent<Renderer>().material.color==plane.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=20;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();
        //StartCoroutine(speedChng());
        }
        if(GetComponent<Renderer>().material.color==plane2.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=50;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();
        //StartCoroutine(speedChng());
        }
    }
    IEnumerator speedChng(){
        for(int i=0; i<17;i++){
        speed.GetComponent<UnityEngine.UI.Text>().fontSize=speed.GetComponent<UnityEngine.UI.Text>().fontSize+3;
        yield return new WaitForSeconds(animationDuration);
        }
        
        for(int i=0; i<17;i++){
        speed.GetComponent<UnityEngine.UI.Text>().fontSize=speed.GetComponent<UnityEngine.UI.Text>().fontSize-3;
        yield return new WaitForSeconds(animationDuration);
        }
    }
}
