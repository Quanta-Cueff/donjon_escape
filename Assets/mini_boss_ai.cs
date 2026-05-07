using UnityEngine;

public class mini_boss_ai : MonoBehaviour
{
    public GameObject player;
    public float coldawne;
    public bool ison;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coldawne > 0 & ison)
        {
            coldawne -= Time.deltaTime;
        }
        else
        {
            var distance = Mathf.Sqrt(((transform.position.x-player.transform.position.x)
                                      *(transform.position.x-player.transform.position.x))
                                      +(transform.position.y-player.transform.position.y)
                                      *(transform.position.y-player.transform.position.y));
            if(distance < 5)
            {
                
            }
            else if(distance > 30)
            {

            }
            else
            {
                
            }
        }
    }
}
