using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject count;
    public PlaayerMovement force;
    int cc=0;
    public GameObject theBox;
    public GameObject box=GameObject.Find("box");
    public GameObject box1=GameObject.Find("box (1)");
    public GameObject box2= GameObject.Find("box (2)");
    public GameObject plane= GameObject.Find("Plane");
    public GameObject plane2= GameObject.Find("Plane (2)");
    public GameObject speed=GameObject.Find("speed");

    // Start is called before the first frame update
    void OnCollisionEnter(Collision ColInf){
        count=GameObject.Find("count");
        
        Debug.Log("Collision! " + ColInf.collider.name);
        
        if(ColInf.collider.name!="Plane"){
        theBox=GameObject.Find("ColInf.collider.name");
            cc++;
            GetComponent<Renderer>().material.color = ColInf.collider.GetComponent<Renderer>().material.GetColor("_Color");
            count.GetComponent<UnityEngine.UI.Text>().text = "" + cc;

            /* for(int i=count.GetComponent<UnityEngine.UI.Text>().fontSize; i<count.GetComponent<UnityEngine.UI.Text>().fontSize+10; i++){
                count.GetComponent<UnityEngine.UI.Text>().fontSize=i;
            }
            for(int i=count.GetComponent<UnityEngine.UI.Text>().fontSize+10; i>=count.GetComponent<UnityEngine.UI.Text>().fontSize; i++){
                count.GetComponent<UnityEngine.UI.Text>().fontSize=i;
            } animation*/
        }
        if(GetComponent<Renderer>().material.color==box.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=25;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();}
        if(GetComponent<Renderer>().material.color==box1.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=10;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();}
        if(GetComponent<Renderer>().material.color==box2.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=15;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();}
        if(GetComponent<Renderer>().material.color==plane.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=20;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();}
        if(GetComponent<Renderer>().material.color==plane2.GetComponent<Renderer>().material.GetColor("_Color")){
        force.force=50;
        speed.GetComponent<UnityEngine.UI.Text>().text = force.force.ToString();}
    }
}
