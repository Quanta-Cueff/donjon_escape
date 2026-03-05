using UnityEngine;

public class tourel_manageur : MonoBehaviour
{
    public float minuteur;
    public GameObject projectile;
    public float coldawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (minuteur <= 0)
        {
            projectile.transform.position = transform.position;
            projectile.GetInstanceID();
            minuteur = coldawn;
        }
        else
        {
            minuteur -= Time.deltaTime;
        }
    }
}
