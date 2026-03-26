using UnityEngine;

public class interupeteur_managaur : MonoBehaviour
{
    public Rigidbody2D rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rd.rotation += 1;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "levier")
        {
            collision.gameObject.GetComponent<interupteur>().nf = true;
        }
    }
}
