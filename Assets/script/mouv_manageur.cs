using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using TMPro;


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
    public Image image;
    public float emeteur;
    public bool onoff;
    private float time_flore;
    private float meta_time_flore;
    public float wolljumpe_dbufe;
    public TextMeshProUGUI textMeshProUGUI;
    public mana_manageur mana;
    public bool GOD_mode;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GOD_mode)
        {
            hp = max_hp;
        }
        if(flor.flor & Input.GetAxis("Horizontal") == 0)
        {
            rd.linearVelocityX *= 0.7f;
        }
        textMeshProUGUI.text = $"pv "+(hp)+"/"+(max_hp);
        image.fillAmount = hp / max_hp;
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
            rd.linearVelocity *= 0;
            mana.usemana(-100);
        }
        if (wole_jump_coldawne <= 0)
        {
            rd.linearVelocityX = Input.GetAxis("Horizontal") * wolljumpe_dbufe * speed;
            if (rd.linearVelocityX > speed)
            {  rd.linearVelocityX = speed; }
            if (rd.linearVelocityX < -speed)
            { rd.linearVelocityX = -speed; }
            if (wolljumpe_dbufe < 1)
            { wolljumpe_dbufe += Time.deltaTime * 0.2f; }
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
            if (meta_time_flore <= 0)
            {
                jump = true;
            }
            
            time_flore = 0.5f;
        }
        else if (time_flore > 0f )
        {
            time_flore -= Time.deltaTime;
        }

        if (meta_time_flore > 0)
        {
            meta_time_flore -= Time.deltaTime;
        }

        if (time_flore > 0f)
        {
            if (jump & Input.GetKey(KeyCode.Space))
            {
                
                jump = false;
                meta_time_flore = 0.1f;
                rd.linearVelocityY += streng_jump;
            }
        }
        
        if (listo_Of_Power.WJ & meta_time_flore <= 0)
        {

            if (wole_left.wole)
            {
                
                if (Input.GetKey(KeyCode.Space) & wole_jump_coldawne <= 0f & Input.GetAxis("Horizontal") == -1)
                {
                    rd.linearVelocity += new Vector2(streng_wole_jump*3, streng_wole_jump);
                    wole_jump_coldawne = 0.5f;
                    wolljumpe_dbufe = 0.45f;
                }
                else if(wole_jump_coldawne <= 0f) { rd.linearVelocityY = 0; }
            }
            if (wole_right.wole)
            {
                
                if (Input.GetKey(KeyCode.Space) & wole_jump_coldawne <= 0f & Input.GetAxis("Horizontal") == 1)
                {
                    rd.linearVelocity += new Vector2(-streng_wole_jump*3, streng_wole_jump);
                    wole_jump_coldawne = 0.5f;
                    wolljumpe_dbufe = 0.45f;
                }
                else if(wole_jump_coldawne <= 0f) { rd.linearVelocityY = 0; }
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
