using NUnit.Framework.Internal.Filters;
using UnityEngine;

public class mini_boss_ai : MonoBehaviour
{
    public GameObject player;
    public GameObject attaque;
    public mouv_manageur player_mouver;
    public float coldawne;
    public float coldawne2;
    public bool ison;
    public Animator anim;
    public Rigidbody2D rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ison)
        {
            if (coldawne2 > 0)
            {
                print("a");
                coldawne2 -= Time.deltaTime;
                if (coldawne2 <= 0)
                {
                    anim.SetBool("grossattaqu", false);
                    if (Mathf.Sqrt(((transform.position.x - player.transform.position.x)
                                          * (transform.position.x - player.transform.position.x))
                                          + (transform.position.y - player.transform.position.y)
                                          * (transform.position.y - player.transform.position.y)) < 5 
                                          & (transform.position.x - player.transform.position.x) < 3)
                    {
                        player_mouver.hp -= 10;
                    }
                }
            }
            if (coldawne > 0 )
            {
                if(!(coldawne2 > 0))
                {
                    coldawne -= Time.deltaTime;
                    if ((transform.position.x - player.transform.position.x) > 0)
                    {
                        rd.linearVelocityX = -2;
                        transform.localScale = new Vector3(-1, 1, 1);
                    }
                    else
                    {
                        rd.linearVelocityX = 2;
                        transform.localScale = new Vector3(1, 1, 1);
                    }
                }
                
            }
            else
            {
                var distance = Mathf.Sqrt(((transform.position.x - player.transform.position.x)
                                          * (transform.position.x - player.transform.position.x))
                                          + (transform.position.y - player.transform.position.y)
                                          * (transform.position.y - player.transform.position.y));
                attaque.active = false;
                anim.SetBool("attaqu", false);

                if (distance < 5)
                {
                    rd.linearVelocityX = 0;
                    anim.SetBool("grossattaqu", true);
                    coldawne2 = 1;
                    coldawne = 5;
                }
                else if (distance > 20)
                {
                    anim.SetBool("attaqu", true);
                    attaque.active = true;
                    coldawne = 10;
                }
                else
                {
                    coldawne = 3;
                }
            }
        }
    }
}
