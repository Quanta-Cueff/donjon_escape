using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class tchet_managuer : MonoBehaviour
{
    public power_up power_Up;
    public GameObject player;
    public mana_manageur mana_Manageur;
    public mouv_manageur mouv_Manageur;
    public listo_of_power listo_Of_Power;
    public Toggle tp;
    public Toggle sh;
    public Toggle wj;
    public Toggle sw;
    public Toggle mr;
    public TextMeshProUGUI textmana;
    public TextMeshProUGUI textpv;
    public TextMeshProUGUI textspeed;
    public Toggle godmode;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tp.isOn = listo_Of_Power.TP;
        sh.isOn = listo_Of_Power.Sh;
        wj.isOn = listo_Of_Power.WJ;
        sw.isOn = listo_Of_Power.Sw;
        mr.isOn = listo_Of_Power.MR;

    }

    // Update is called once per frame
    void Update()
    {
        if(godmode.isOn)
        {
            mouv_Manageur.hp = mouv_Manageur.max_hp;
        }
        textmana.text = "mana max " + mana_Manageur.mana_max;
        textpv.text = "pv max " + mouv_Manageur.max_hp;
        textspeed.text = "speed " + mouv_Manageur.speed;

        listo_Of_Power.TP =tp.isOn;
        listo_Of_Power.Sh =sh.isOn;
        listo_Of_Power.WJ =wj.isOn;
        listo_Of_Power.Sw =sw.isOn;
        listo_Of_Power.MR =mr.isOn;
    }
    public void upmana()
    {
        power_Up.power_grow(0,1,0,player);
    }
    public void downmana()
    {
        power_Up.power_grow(0,-1,0,player);

    }
    public void uppv()
    {
        power_Up.power_grow(1,0,0,player);
    }
    public void downpv()
    {
        power_Up.power_grow(-1,0,0,player);
    }
    public void upspeed()
    {
        power_Up.power_grow(0,0,1,player);
        
    }
    public void downspeed()
    {
        power_Up.power_grow(0,0,-1,player);
        
    }
}
