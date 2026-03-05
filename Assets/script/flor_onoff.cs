using UnityEngine;

public class flor_onoff : MonoBehaviour
{
    public bool flor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        flor = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        flor = false;
    }
}
