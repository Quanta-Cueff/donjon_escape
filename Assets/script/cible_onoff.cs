using Unity.VisualScripting;
using UnityEngine;

public class cible_onoff : MonoBehaviour
{
    public bool cible;
    private float minuteur;
    public Rigidbody2D rd;
    public mana_manageur mana;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mana.mana < 5 | cible)
        { 
            gameObject.GetComponent<Renderer>().material.color = new Color(1f, 0.3f, 0.3f);
        }
        else 
        { 
            gameObject.GetComponent<Renderer>().material.color = new Color(0.8f, 0.8f, 0.8f);
        }

        if (minuteur <= 0)
        {

            if (cible)
            { 
                
                rd.rotation += 180;
            }
            minuteur = 1f;
            cible = false;
        }
        else 
        {
            minuteur -= Time.deltaTime;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.isTrigger)
        {
            minuteur = 0.1f;
            cible = true;
        }
    }
}
