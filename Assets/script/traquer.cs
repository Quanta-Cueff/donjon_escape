using UnityEngine;

public class traquer : MonoBehaviour
{
    public Rigidbody2D rd;
    public Transform cible;
    public Vector2 vector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rd.rotation = Mathf.Atan2((cible.position.y + vector.y) - transform.position.y, (cible.position.x + vector.x) - transform.position.x) * Mathf.Rad2Deg - 90;

    }
}
