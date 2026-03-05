using UnityEngine;

public class wole_onoff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool wole;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        wole = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        wole = false;
    }
}
