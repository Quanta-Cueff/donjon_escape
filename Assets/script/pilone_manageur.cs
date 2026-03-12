using UnityEngine;

public class pilone_manageur : MonoBehaviour
{
    public bool nf;
    private bool NF;
    private bool surnf;
    private Vector3 position;
    private float hoteur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (nf & hoteur > 0)
        { 
            hoteur -= Time.deltaTime;
        }
        if (!nf & hoteur < 3)
        {
            hoteur += Time.deltaTime;
        }
        transform.position = position + new Vector3 (0,hoteur,0);

    }
}
