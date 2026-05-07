using UnityEngine;

public class attaque_manageur : MonoBehaviour
{
    public power_manageur power;
    public mana_manageur mana;
    public Rigidbody2D rd;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        power = GetComponent<power_manageur>();
        mana = GetComponent<mana_manageur>();

        rd.linearVelocity = transform.up * transform.localScale.z;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (!collision.isTrigger & collision.gameObject.name == "Player")
             
        {
            
            var mouv_manageurs = collision.gameObject.GetComponent<mouv_manageur>();
            mouv_manageurs.hp -= 1;
            Object.Destroy(gameObject);
        }

        if (collision.gameObject.name == "wole_ring" |
            collision.gameObject.name == "wole_left" |
            collision.gameObject.name == "shelde")
        {
            
            var emeteur = collision.gameObject.GetComponent<emeteur>();
            emeteur.valu += 1;
            emeteur.nf = true;
            Object.Destroy(gameObject);
        }
        if (!collision.isTrigger & !(collision.name == "liche"))
        {
            
            Object.Destroy(gameObject);
        }
    }

}
