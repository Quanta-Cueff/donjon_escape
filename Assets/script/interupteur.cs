using UnityEngine;

public class interupteur : MonoBehaviour
{
    public pilone_manageur manageur;
    public bool nf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nf & Input.GetMouseButtonDown(1))
        {
            manageur.nf = !manageur.nf;
        }
        nf = false;
    }
    
}
