using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Number_Gold : MonoBehaviour
{
    private TextMeshProUGUI GoldText;

    // Start is called before the first frame update
    void Start()
    {
        GoldText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateGoldText(PlayerInventory playerInventory)
    {
        string str = playerInventory.NumberOfGold.ToString();
        GoldText.text = str + " / 2";
    }
    
}
