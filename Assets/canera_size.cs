using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class canera_size : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Scrollbar scrollbar;
    public Camera camerat;
    public TextMeshProUGUI textMeshPro;

    // Update is called once per frame
    void Update()
    {
        camerat.orthographicSize = ((scrollbar.value*3) + 1) * 5f;
        textMeshPro.text = "taill de la camera(x" + ((scrollbar.value * 3) + 1) + ")";

    }
}
