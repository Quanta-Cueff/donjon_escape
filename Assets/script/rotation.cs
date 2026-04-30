using UnityEngine;

public class rotation : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rd.rotation += speed * Time.deltaTime;
    }
}
