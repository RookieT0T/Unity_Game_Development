using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Number_Silver : MonoBehaviour
{
    private TextMeshProUGUI SilverText;

    // Start is called before the first frame update
    void Start()
    {
        SilverText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSilverText(PlayerInventory playerInventory)
    {
        //print(playerInventory.NumberOfSilver.ToString());
        SilverText.text = playerInventory.NumberOfSilver.ToString() + " / 3";
        //print(SilverText.text);
    }
}
