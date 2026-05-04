using UnityEngine;

public class change_level_manageur : MonoBehaviour
{
    public bool onoff;
    public float anime;
    public GameObject panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panel.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (onoff)
        {
            if (anime >= 2)
            {
                onoff = false;
            }
            else
            {
                anime += Time.deltaTime;
                panel.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, (anime/2));
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        onoff = true;
        panel.active = true;
    }
}
