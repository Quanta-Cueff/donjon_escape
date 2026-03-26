using UnityEngine;
using UnityEngine.UI;

public class mana_recharge : MonoBehaviour
{
    public mana_manageur mana;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mana = GameObject.Find("mana").GetComponent<mana_manageur>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        { 
            timer -= Time.deltaTime;
        } else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.8f, 0.5f);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" & timer <= 0)
        {
            mana.usemana(-100);
            gameObject.GetComponent<Renderer>().material.color = new Color(0.2f, 0.3f, 0.5f);
            timer = 5;
        }
    }
}
