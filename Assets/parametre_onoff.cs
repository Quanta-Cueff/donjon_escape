using UnityEngine;

public class parametre_onoff : MonoBehaviour
{
    public GameObject panel;
    public bool is_on;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void onoff()
    {
        
            panel.SetActive(is_on);
            is_on = !is_on;
    }
}
