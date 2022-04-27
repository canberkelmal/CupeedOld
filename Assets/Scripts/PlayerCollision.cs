using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision ColInf){
        
        Debug.Log("Collision! " + ColInf.collider.name);
        
        if(ColInf.collider.name!="Plane")
        GetComponent<Renderer>().material.color = ColInf.collider.GetComponent<Renderer>().material.GetColor("_Color");

    }
}
