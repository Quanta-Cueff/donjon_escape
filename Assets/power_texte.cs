using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class power_texte : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public float time;
    public void powertext(Text power)
    {
        transform.position *= 0;
        transform.localScale *= 0;
        time = 0;
        textMeshPro.text = power.text;
    }
    private void Update()
    {
        if (time > 1)
        { 
            transform.position = new Vector3(transform.position.x, transform.position.y+(Time.deltaTime),0);
            transform.localScale = new Vector3(1 / time, 1 / time, 1);
            time += Time.deltaTime;
        }
    }
}
