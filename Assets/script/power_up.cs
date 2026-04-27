using UnityEngine;


public class power_up : MonoBehaviour
{
    public listo_of_power listo_Of_Power;
    public mana_manageur mena;
    public power_texte power_Texte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.name == "Player")
        {
            var liste = collision.GetComponent<listo_of_power>();
            if (!liste.TP & listo_Of_Power.TP)
            {
                print("tp");
                power_grow(1,1,1,collision.gameObject);
                liste.TP = listo_Of_Power.TP;
                power_Texte.powertext("téléportation");
            }
            if (!liste.Sh & listo_Of_Power.Sh)
            {
                print("shilde");
                power_grow(2, 1, 1, collision.gameObject);
                liste.Sh = listo_Of_Power.Sh;
                power_Texte.powertext("bouclier");

            }
            if (!liste.WJ & listo_Of_Power.WJ)
            {
                print("wole jumpe");
                power_grow(1, 1, 1, collision.gameObject);
                liste.WJ = listo_Of_Power.WJ;
                power_Texte.powertext("wole jumpe");

            }
            if (!liste.Sw & listo_Of_Power.Sw)
            {
                print("sword");
                power_grow(1, 1, 1, collision.gameObject);
                liste.Sw = listo_Of_Power.Sw;
                power_Texte.powertext("épée de mana");

            }
            if (!liste.MR & listo_Of_Power.MR)
            {
                print("mana regen");
                power_grow(1, 2, 1, collision.gameObject);
                liste.MR = listo_Of_Power.MR;
                power_Texte.powertext("régénération de mana");

            }
            Destroy(gameObject);
        }
    }
     public void power_grow(float hp, float mana, float speed, GameObject player)
     {
        var stat = player.GetComponent<mouv_manageur>();
        stat.max_hp += hp;
        stat.speed += speed;
        stat.emeteur += mana;
        stat.onoff = true;
    }

}

