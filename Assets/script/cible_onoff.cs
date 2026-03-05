using Unity.VisualScripting;
using UnityEngine;

public class cible_onoff : MonoBehaviour
{
    public bool cible;
    private float minuteur;
    public Rigidbody2D rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
