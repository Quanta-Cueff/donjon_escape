using UnityEngine;
using UnityEngine.Tilemaps;

public class interupteur : MonoBehaviour
{
    public pilone_manageur manageur;
    public bool nf;
    public bool ison;
    public Tilemap tile;
    private float coldawne;
    private bool flip_flop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(coldawne > 0)
        {
            coldawne -= Time.deltaTime;
            flip_flop =true;
        }else if(flip_flop)
        {
            tile.color *= 2f;
            flip_flop = false;
        }
        if (nf & Input.GetMouseButtonDown(1))
        {
            tile.color *= 0.5f;
            manageur.nf = !manageur.nf;
            ison =! ison;
            coldawne = 0.5f;
        }
        nf = false;
    }
    
}
