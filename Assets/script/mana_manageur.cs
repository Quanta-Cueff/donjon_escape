using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class mana_manageur : MonoBehaviour
{
    public emeteur emeteur;
    public float mana_max;
    public float mana;
    public Image Image;
    public listo_of_power listo_Of_Power;
    private float minuteur;
    public mouv_manageur mouv;
    public TextMeshProUGUI textMeshPro;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(mouv.onoff)
        {
            mouv.onoff = false;
            mana_max += mouv.emeteur * 5;
            usemana(0);
            mouv.emeteur = 0;
        }
        if (emeteur.nf)
        {
            usemana(emeteur.valu);
            emeteur.valu = 0;
            emeteur.nf = false;
        }
        if (listo_Of_Power.MR == true)
        {
            if(minuteur <= 0)
            {
                minuteur = 0.5f;
                usemana(-1);
            }
            else
            {
                minuteur -= Time.deltaTime;
            }
        }
    }
    public bool usemana(float use)
    {
        if (mana >= use) 
        { 
            mana -= use;
            if (mana > mana_max)
            { mana = mana_max;}
            Image.fillAmount = mana / mana_max;
            textMeshPro.text = $"pm          "+mana+"/"+mana_max;
            return true;
        }else 
        {return false;}
    }
}
