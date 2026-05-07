using UnityEngine;

public class tourel_manageur : MonoBehaviour
{
    public float minuteur;
    public GameObject projectile;
    public float coldawn;
    public float size = 0.3f;
    public float speed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (minuteur <= 0)
        {
            var newProj = Instantiate(projectile,transform.position, transform.rotation);
            newProj.transform.localScale = new Vector3(size,size,speed);
            minuteur = coldawn;
        }
        else
        {
            minuteur -= Time.deltaTime;
        }
    }
}
