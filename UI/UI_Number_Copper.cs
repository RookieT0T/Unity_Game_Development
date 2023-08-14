using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Number_Copper : MonoBehaviour
{
    private TextMeshProUGUI CopperText;

    // Start is called before the first frame update
    void Start()
    {
        CopperText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCopperText(PlayerInventory playerInventory)
    {
        string str = playerInventory.NumberOfCopper.ToString();
        CopperText.text = str + " / 4";
    }
}
