using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SunCollectUI : MonoBehaviour
{
    private TextMeshProUGUI sunText;

    void Start()
    {
        sunText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateWaterText(PlayerInventory playerInventory)
    {
        sunText.text = playerInventory.AmountOfSun.ToString();
    }
}
