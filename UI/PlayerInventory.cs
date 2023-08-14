using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfCopper = 0;
    public int NumberOfSilver = 0;
    public int NumberOfGold = 0;

    public UnityEvent<PlayerInventory> OnGoldCollected;
    public UnityEvent<PlayerInventory> OnSilverCollected;
    public UnityEvent<PlayerInventory> OnCopperCollected;

    public void CopperCollected()
    {
        NumberOfCopper++;
        OnCopperCollected.Invoke(this);
    }

    public void SilverCollected()
    {
        NumberOfSilver++;
        OnSilverCollected.Invoke(this);
    }

    public void GoldCollected()
    {
        NumberOfGold++;
        OnGoldCollected.Invoke(this);
    }

    public int totalNumber()
    {
        int total = NumberOfCopper + NumberOfGold + NumberOfSilver;
        return total;
    }
}
