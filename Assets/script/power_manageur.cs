using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class power_manageur : MonoBehaviour
{
    public Transform cible_position;
    public Rigidbody2D rd;
    public cible_onoff cible;
    public mana_manageur mana;
    public GameObject cible_image;
    public sword sword_left;
    public sword sword_right;
    public listo_of_power listo_Of_Power;
    public GameObject shelde;
    public GameObject tp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(listo_Of_Power.Sh) 
        {
            shelde.active = true;
        }
        else
        {
            shelde.active = false;
        }

        if (listo_Of_Power.TP)
        {
            tp.active = true;
        }
        else
        {
            tp.active = false;
        }

        if (Mathf.Sqrt(((Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y) * (Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y)) +
            ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x) * (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x))) > 3f)
        {
            cible_image.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0);

        }
        else
        {
            cible_image.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
            cible_position.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);

            if (Input.GetMouseButtonDown(0) & !cible.cible)
            {
                if (mana.usemana(5))
                {
                    transform.position = cible_position.position;
                    rd.linearVelocity = new Vector2(rd.linearVelocityX, 0);
                }
            }
            else if (Input.GetMouseButtonDown(0) & cible.cible)
            {
                if (listo_Of_Power.Sw)
                {
                    float direction = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - rd.position.x;
                    if (sword_left.sword_zone & direction < 0)
                    {
                        attaque(sword_left.GameObject_zone);
                    }

                    if (sword_right.sword_zone & direction > 0)
                    {
                        attaque(sword_right.GameObject_zone);
                    }
                }
            }
        }
    }
    public void attaque(GameObject zone)
    {
        var destructible = zone.GetComponent<destructibel>();
        if (destructible.destuctible)
        {
            if (destructible.insta_breack)
            {
                Object.Destroy(zone);
            }
            else 
            {
                destructible.pv -= 1;
                if(destructible.pv <= 0)
                {
                    Object.Destroy(zone);
                }
            }
        }
    }
}
