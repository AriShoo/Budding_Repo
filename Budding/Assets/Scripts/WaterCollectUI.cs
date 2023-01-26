using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterCollectUI : MonoBehaviour
{
    private TextMeshProUGUI waterText;

    void Start()
    {
        waterText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateWaterText(PlayerInventory playerInventory)
    {
        waterText.text = playerInventory.AmountOfWater.ToString();
    }
}
