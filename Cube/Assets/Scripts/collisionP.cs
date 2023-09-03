using UnityEngine;

public class collisionP : MonoBehaviour
{
    public NewBehaviourScript movement; //Reference to the playermovement script

    //Theis function runs when we hit another object
 void OnCollisionEnter(Collision collisioninfo)
 {
    if(collisioninfo.collider.tag == "Obsticle") // Checks if we collided with the Obstacle
    {
        movement.enabled = false; // Disables player movement 
        FindObjectOfType<GameManager>().Gameover();
    }
 }
}
