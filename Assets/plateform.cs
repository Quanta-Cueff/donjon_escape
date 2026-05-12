using UnityEngine;

public class plateform : MonoBehaviour
{
    public Transform cyble;
    private Vector3 position;
    private Vector3 cyble_position;
    private float max_distanc;
    private float coldawne;
    private bool flip_flop = true;
    public interupteur interupteur;
    public bool passe;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position=transform.position;
        cyble_position = cyble.transform.position;
        max_distanc =Mathf.Sqrt(((transform.position.x - cyble.transform.position.x)
                               * (transform.position.x - cyble.transform.position.x))
                               + (transform.position.y - cyble.transform.position.y)
                               * (transform.position.y - cyble.transform.position.y));
    }

    // Update is called once per frame
    void Update()
    {
        if(interupteur.ison | passe)
        {
            if(flip_flop)
            {
            coldawne += (Time.deltaTime*speed) / max_distanc;
            }
            else
            {
                coldawne -= (Time.deltaTime*speed) / max_distanc;
            }
            if(coldawne > 1)
            {
                flip_flop = false;
            }
            else if(coldawne < 0)
            {
             flip_flop = true;
            }
            transform.position = (cyble_position*coldawne) + position *(1-coldawne);
        }
        
    }
}
