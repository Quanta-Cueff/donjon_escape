using UnityEngine;
using UnityEngine.XR;

public class mouv_manageur : MonoBehaviour
{
    public emeteur emeteurR;
    public emeteur emeteurL;
    public Transform spawn_pont;
    public float max_hp;
    public float hp;
    public listo_of_power listo_Of_Power;
    public float speed;
    private bool jump;
    public float streng_jump;
    public flor_onoff flor;
    public float streng_wole_jump;
    public Rigidbody2D rd;
    public wole_onoff wole_left;
    public wole_onoff wole_right;
    private float wole_jump_coldawne;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (emeteurL.nf)
        {
            hp -= emeteurL.valu;
            emeteurL.valu = 0;
            emeteurL.nf = false;
        }
        if (emeteurR.nf)
        {
            hp -= emeteurR.valu;
            emeteurR.valu = 0;
            emeteurR.nf = false;
        }

        if (hp <= 0)
        {
            transform.position = spawn_pont.position;
            hp = max_hp;
        }
        if (wole_jump_coldawne <= 0)
        {
            rd.linearVelocityX += Input.GetAxis("Horizontal") * 0.1f * speed;
            if (rd.linearVelocityX > speed)
            {  rd.linearVelocityX = speed; }
            if (rd.linearVelocityX < -speed)
            { rd.linearVelocityX = -speed; }
        }
        else 
        {
            if (rd.linearVelocityX > streng_wole_jump)
            { rd.linearVelocityX = streng_wole_jump; }
            if (rd.linearVelocityX < -streng_wole_jump)
            { rd.linearVelocityX = -streng_wole_jump; }
        }

        if (flor.flor)
        {
            if (jump & Input.GetKey(KeyCode.Space))
            {
                jump = false;
                rd.linearVelocityY += streng_jump;
            }
        }
        else
        {
            jump = true;
        }
        if (listo_Of_Power.WJ)
        {
            if (wole_left.wole & Input.GetKey(KeyCode.Space) & wole_jump_coldawne <= 0f & Input.GetAxis("Horizontal") != -1)
            {
                rd.linearVelocity += new Vector2(streng_wole_jump, streng_wole_jump);
                wole_jump_coldawne = 0.5f;
            }
            if (wole_right.wole & Input.GetKey(KeyCode.Space) & wole_jump_coldawne <= 0f & Input.GetAxis("Horizontal") != 1)
            {
                rd.linearVelocity += new Vector2(-streng_wole_jump, streng_wole_jump);
                wole_jump_coldawne = 0.5f;
            }
            if (wole_jump_coldawne > 0f)
            {
                wole_jump_coldawne -= Time.deltaTime;
            }
        }
        else
        { 
           if(wole_left.wole)
            {
                rd.linearVelocity += new Vector2(speed, 0) * 0.1f;
                
            }
            if (wole_right.wole)
            {
                rd.linearVelocity += new Vector2(-speed, 0) * 0.1f;
                
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "recharge")
        {
            spawn_pont = collision.transform;
        }

    }
}
