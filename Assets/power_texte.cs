using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class power_texte : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public float time;
    public Transform position;
    public TextMeshPro TextMeshPro;
    public void Start()
    {
        transform.position = position.position;
        transform.localScale *= 0;
    }
    public void powertext(string power)
    {
        transform.position = position.position;
        transform.localScale *= 0;
        time = 0;
        textMeshPro.text = power;
    }
    private void Update()
    {
        if (time < 1)
        { 
            transform.position = new Vector3(0,(time*2),0) + position.position;
            transform.localScale = new Vector3(Mathf.Sqrt(time), Mathf.Sqrt(time), 1);
            time += Time.deltaTime/3;
            textMeshPro.color = new Color(1, 1, 1, (1 / time) - 1);
        }
    }
}
