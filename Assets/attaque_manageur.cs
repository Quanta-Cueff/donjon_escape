using UnityEngine;

public class attaque_manageur : MonoBehaviour
{
    public power_manageur power;
    public mana_manageur mana;
    public Rigidbody2D rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = GetComponent<power_manageur>();
        mana = GetComponent<mana_manageur>();
        rd.linearVelocityX = 1;
    }

    // Update is called once per frame
    void Update()
    { 
    
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.isTrigger )
        {
            power.attaque(collision.gameObject);
        }

        if (collision.name == "sheld")
        {
            mana.usemana(1);
        }
    }

}
