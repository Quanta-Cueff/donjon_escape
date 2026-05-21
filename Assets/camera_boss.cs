using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class camera_boss : MonoBehaviour
{
    public Camera canera;
    public Scrollbar scrollbar;
    private float coldawne = 1;
    private float camera_size;
    public GameObject boss;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Update()
    {
        if(coldawne < 1)
        {
            coldawne += Time.deltaTime;
            canera.orthographicSize = camera_size*(1f-coldawne)+ 15f*coldawne;
            scrollbar.value = ((camera_size*(1f-coldawne)+ 15f*coldawne)-5)/15;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            coldawne = 0;
            camera_size = canera.orthographicSize;
            boss.active = true;
        }
        
    }
}    