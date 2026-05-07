using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class discution_manageur : MonoBehaviour
{
    public List<string> text;
    public List<bool> is_player;
    private int anvancemant;
    public GameObject player_panel;
    public GameObject boss_panel;
    public TextMeshProUGUI player_text;
    public TextMeshProUGUI boss_text;
    public GameObject panel_de_discution;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void next_text()
    {
        if(anvancemant < text.Count)
        {
            panel_de_discution.active = true;

            player_panel.active = is_player[anvancemant];
            boss_panel.active = !is_player[anvancemant];
            if(is_player[anvancemant])
            {
                player_text.text = text[anvancemant];
            }
            else
            {
                boss_text.text = text[anvancemant];
            }
         anvancemant ++;
        }
        else
        {
            print(anvancemant);
            print(text.Count);
            panel_de_discution.active =false;
        }

    }
    public void skip()
    {
        anvancemant = text.Count + 1;
        panel_de_discution.active = false;
    }
}
