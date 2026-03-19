using UnityEngine;

public class dangeu_manageur : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerStay2D(Collider2D collision)
    { 
        if (collision.name == "Player")
        {
            var mouv_manageurs = collision.gameObject.GetComponent<mouv_manageur>();
            mouv_manageurs.hp = 0;
        }
    }


}
