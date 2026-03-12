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
        transform.localEulerAngles += new Vector3(1,-1,1) * Time.deltaTime * speed;
    }
}
