using System.Collections.Generic;
using UnityEngine;

public class liche_ai : MonoBehaviour
{
    public Transform player;
    private float minuter;
    public List<GameObject> attaque_list;
    public List<float> coldawne_list;
    public float coldawne;
    private int random;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (minuter > 0)
        {
            minuter -= Time.deltaTime;

        } else if (Mathf.Abs(transform.position.x - player.position.x) < 7)
        {
            transform.position = new Vector2(-transform.position.x,transform.position.y) ;
            gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
            minuter = 3f;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f);

        }

        if (coldawne > 0)
        {
            coldawne -= Time.deltaTime;
            if (coldawne < 1f)
            {
                attaque_list[random].active = false;
            }
        }
        else
        {
            random = Random.Range(0, attaque_list.Count);
            attaque_list[random].active = true;
            coldawne = coldawne_list[random];
        }
    }
}
