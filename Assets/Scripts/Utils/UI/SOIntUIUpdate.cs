using TMPro;
using UnityEngine;

public class SOIntUIUpdate : MonoBehaviour
{
    public SOInt soInt;
    public TextMeshProUGUI uiTextvalue;

    void Start()
    {
        uiTextvalue.text = soInt.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        uiTextvalue.text = soInt.value.ToString();
    }
}
