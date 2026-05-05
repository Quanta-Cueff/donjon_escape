using UnityEngine;
using UnityEngine.UI;

public class tchet_managuer : MonoBehaviour
{
    public mouv_manageur mouv_Manageur;
    public mana_manageur mana_Manageur;
    public listo_of_power listo_Of_Power;
    public Toggle tp;
    public Toggle sh;
    public Toggle wj;
    public Toggle sw;
    public Toggle mr;
    
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
        listo_Of_Power.TP =tp.isOn;
        listo_Of_Power.Sh =sh.isOn;
        listo_Of_Power.WJ =wj.isOn;
        listo_Of_Power.Sw =sw.isOn;
        listo_Of_Power.MR =mr.isOn;
    }
}
