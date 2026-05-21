using UnityEngine;

public class skybox : MonoBehaviour
{
    public Transform player;
    public bool chut;
    private float altitude;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (player.transform.position * 0.9f) + new Vector3(0,altitude*7,0);
        if (chut)
        {
            altitude += Time.deltaTime;
            if (altitude > 5)
            {
                altitude -= 5;
            }
        }
    }
}
