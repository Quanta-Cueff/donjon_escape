using UnityEngine;
using UnityEngine.SceneManagement;

public class titel_manageur : MonoBehaviour
{
    public GameObject lvl_panel;
    public GameObject titel_panel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start_game(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void lvlpanel()
    {
        lvl_panel.active = true;
        titel_panel.active = false;
    }
    public void lvltitel()
    {
        lvl_panel.active = false;
        titel_panel.active = true;
    }
    public void quit_game()
    {
        Application.Quit();
    }
}
