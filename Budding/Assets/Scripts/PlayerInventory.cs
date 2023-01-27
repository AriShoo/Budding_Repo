using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int AmountOfWater { get; private set; }

    public UnityEvent<PlayerInventory> OnWaterCollected;
 //   public WaterCollectUI WaterCollect;

    public void WaterCollected()
    {
        AmountOfWater++;
        OnWaterCollected.Invoke(this);
    }
}
