using UnityEngine;

public class debuge_rispawne : MonoBehaviour
{
    public mouv_manageur mouv_manageur;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void rispawn()
    {
        mouv_manageur.hp = 0;
    }
}
