using UnityEngine;

public class tp_animation : MonoBehaviour
{
    public bool anime;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        anim.SetBool("tp",anime);
        if (anime)
        {
            anime = false;
            
        }
    }
}
