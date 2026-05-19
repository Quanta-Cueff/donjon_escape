using UnityEngine;

public class miniboss_trigeur : MonoBehaviour
{
    public Collider2D player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.isTrigger | collision.gameObject.name == "shelde")
        {
            player = collision;
        }
    }
    
        
}    

