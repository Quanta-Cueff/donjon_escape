using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class liche_ai : MonoBehaviour
{
    public Transform player;
    private float minuter;
    public List<GameObject> attaque_list;
    public List<float> coldawne_list;
    public float coldawne;
    private int random;
    public destructibel destructibel;
    public TextMeshProUGUI text;
    public Image image;
    public Animator anim;
    public List<string> listext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        anim.SetBool(listext[random], false);
        text.text = "boss pv " + destructibel.pv + "/3";
        image.fillAmount = destructibel.pv/3;
        if (minuter > 0)
        {
            minuter -= Time.deltaTime;

        } else if (Mathf.Abs(transform.position.x - player.position.x) < 7)
        {
            transform.position = new Vector2(-transform.position.x,transform.position.y) ;
            gameObject.GetComponent<Renderer>().material.color = new Color(0,0,0,0);
            minuter = 4f;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 1f, 1f,0.5f);

        }

        if (coldawne > 0)
        {
            coldawne -= Time.deltaTime;
            if (coldawne < destructibel.pv-1)
            {
                attaque_list[random].active = false;
            }
        }
        else
        {
            random = Random.Range(0, attaque_list.Count);
            attaque_list[random].active = true;
            anim.SetBool(listext[random], true);
            coldawne = coldawne_list[random];
        }
    }
}
