using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{
    public int AmountOfWater { get; private set; }
    public int AmountOfSun {get; private set; }

    public UnityEvent<PlayerInventory> OnWaterCollected;
    public UnityEvent<PlayerInventory> OnSunCollected;
 //   public WaterCollectUI WaterCollect;

    public void Start()
    {
        AmountOfSun = 0;
        AmountOfWater = 0;
    }

    public void WaterCollected()
    {
        AmountOfWater = AmountOfWater + 1;
        OnWaterCollected.Invoke(this);
    }

    public void SunCollected()
    {
        AmountOfSun = AmountOfSun + 1;
        OnSunCollected.Invoke(this);
    }

    public void winState()
    {
        if(AmountOfSun == 4 && AmountOfWater == 4)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
