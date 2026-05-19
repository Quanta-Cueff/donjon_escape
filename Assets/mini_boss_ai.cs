using NUnit.Framework.Internal.Filters;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    public CapsuleCollider2D col;
    public bool run;
    public GameObject box;
    public miniboss_trigeur miniboss_Trigeur;
    public int hp;
    public GameObject panel;
    public Image image;
    public TextMeshProUGUI textMeshProUGUI;
    public mana_manageur mana_Manageur;
    public GameObject flor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        attaque.transform.position= transform.position + new Vector3(2.1f,-0.5f,0);
        if (ison)
        {
            panel.active=true;
            image.fillAmount = hp/3f;
            textMeshProUGUI.text = "golaim de feus "+hp+"/3 HP";
            if(run)
            {
                if(transform.lossyScale.x == 1)
                {
                    rd.linearVelocityX =10;
                }
                else if (transform.lossyScale.x == -1)
                {
                    rd.linearVelocityX =-10;
                }
                if(miniboss_Trigeur.player != null)
                {
                    if(miniboss_Trigeur.player.isTrigger)
                    {
                        if(!mana_Manageur.usemana(10))
                        {
                            player_mouver.hp -= 5;
                        }
                        else
                        {
                            hp -= 1;
                            if(hp==0)
                            {
                                Object.Destroy(flor);
                                Object.Destroy(gameObject);
                            }
                        }
                    }
                    miniboss_Trigeur.player = null;
                    box.active = false;
                    run = false;
                    anim.SetBool("shift", false);

                }
            }
            if (coldawne2 > 0 & !run)
            {
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
                if(!(coldawne2 > 0) & !run)
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
            else if(!run)
            {
                
                col.direction = CapsuleDirection2D.Vertical;
                col.offset= Vector2.zero;
                col.size=new Vector2(2.5f,7) ;
                var distance = Mathf.Sqrt(((transform.position.x - player.transform.position.x)
                                          * (transform.position.x - player.transform.position.x))
                                          + (transform.position.y - player.transform.position.y)
                                          * (transform.position.y - player.transform.position.y));
                attaque.active = false;
                anim.SetBool("attaque", false);

                if (distance < 5)
                {
                    rd.linearVelocityX = 0;
                    anim.SetBool("grossattaqu", true);
                    coldawne2 = 1;
                    coldawne = 3;
                }
                else if (distance > 20)
                {
                    anim.SetBool("attaque", true);
                    attaque.active = true;
                    coldawne = 5;
                }
                else
                {
                    anim.SetBool("shift", true);
                    box.active = true;
                    col.direction = CapsuleDirection2D.Horizontal;
                    col.offset = new Vector2(0,-1.5f);
                    col.size = new Vector2(9,4);
                    run=true;
                    new WaitForSeconds(2);
                    coldawne = 3;

                }
            }
        }
    }
}
