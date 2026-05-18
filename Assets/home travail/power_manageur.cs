using UnityEditor;
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
    public Collider2D shalde;
    public GameObject tp;
    public GameObject tp_effect;
    private float poistion_dorigine_x;
    private float poistion_dorigine_y;
    public float alfa_tp_effect;
    public Animator anime;
    private float coldawn;

    private float x;
    private float y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (coldawn >0)
        {
            coldawn -= Time.deltaTime;
        }

        anime.SetBool("attaque", false);
        if (alfa_tp_effect>0)
        {
            alfa_tp_effect -= Time.deltaTime;
        }
        else
        {
            
        }
        
        if(listo_Of_Power.Sh & !(mana.mana <= 0))
        {
            shalde.enabled = true;
        }
        else
        {
            shalde.enabled = false;
        }
        if (listo_Of_Power.Sh) 
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

        if (Mathf.Sqrt(((Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y) *
                        (Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y)) +
                       ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x) *
                        (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x))) > 3f)
        {
            x = ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x) /
            Mathf.Sqrt(((Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y) *
                        (Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y)) +
                       ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x) *
                        (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x))))*3
              + transform.position.x;

            y = ((Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y) /
            Mathf.Sqrt(((Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y) *
                        (Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y)) +
                       ((Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x) *
                        (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x))))*3
              + transform.position.y;

        }
        else
        {
            x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        }
            cible_position.position = new Vector3(x, y, 0);

            if (Input.GetMouseButtonDown(0) & !cible.cible & listo_Of_Power.TP)
            {
                poistion_dorigine_x = transform.position.x;
                poistion_dorigine_y = transform.position.y;
                if (mana.usemana(5))
                {
                    transform.position = cible_position.position;
                    rd.linearVelocity = new Vector2(rd.linearVelocityX, 0);
                    tp_effect.GetComponent<Rigidbody2D>().rotation = Mathf.Atan2(
                        poistion_dorigine_y - transform.position.y,
                        poistion_dorigine_x - transform.position.x) * Mathf.Rad2Deg;
                    tp_effect.transform.position = (transform.position + new Vector3(poistion_dorigine_x,poistion_dorigine_y,0))/2;
                    tp_effect.transform.localScale = new Vector3(Mathf.Sqrt(((
                         poistion_dorigine_y - transform.position.y) *
                        (poistion_dorigine_y - transform.position.y)) +
                       ((poistion_dorigine_x - transform.position.x) *
                        (poistion_dorigine_x - transform.position.x)))/3,1,1);
                    alfa_tp_effect = 0.1f;
                    tp_effect.GetComponent<tp_animation>().anime = true;

                    
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
    public void attaque(GameObject zone)
    {
        anime.SetBool("attaque", true);
        var destructible = zone.GetComponent<destructibel>();
        if (destructible.destuctible)
        {
            if (destructible.insta_breack)
            {
                Object.Destroy(zone);
            }
            else if(coldawn <= 0)
            {
                coldawn = 1;
                destructible.pv -= 1;
                if(destructible.pv <= 0)
                {
                    Object.Destroy(zone);
                }
            }
        }
    }
}
