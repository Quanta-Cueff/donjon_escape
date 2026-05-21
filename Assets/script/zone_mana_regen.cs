using UnityEngine;

public class zone_mana_regen : MonoBehaviour
{
    public float minuteur;
    public mana_manageur mana;
    public float coldawn= 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (minuteur > 0) 
        {
            minuteur -= Time.deltaTime;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.name == "Player" & minuteur <= 0)
        {
            mana.usemana(-1);
            minuteur = coldawn;
        }
    }
}
