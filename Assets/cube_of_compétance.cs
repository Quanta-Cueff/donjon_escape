using UnityEngine;

public class cube_of_compétance : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.up);
        transform.Rotate(0.25f * Vector3.left);
        transform.Rotate(0.33f * Vector3.forward);
    }
}
