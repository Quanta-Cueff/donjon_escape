using UnityEngine;

public class sword : MonoBehaviour
{
    public bool sword_zone;
    public GameObject GameObject_zone;
    private float minuteur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(minuteur <= 0)
        {
            GameObject_zone = null;
        }
        else 
        {
            minuteur -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        sword_zone = true;
        if(!other.isTrigger)
        {
            minuteur = 3f;
            GameObject_zone = other.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        sword_zone = false;
    }
}
