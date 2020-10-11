using System.Collections.Generic;
using System;
using UnityEngine;

public enum Rarity { Common, Rare, Epic, Legendary }
public enum Slot { Arms, Head, Legs, Chest }

[Serializable]
public class Equipment
{
    public string _name;
    public int _value;
    public Rarity _rarity;
    public Slot _slot;
}

public class Inventory : MonoBehaviour
{
    public Equipment[] _currentlyEquipped;  
    
    public void ClearInventory()
    {
        _currentlyEquipped = new Equipment[0];
    }

    public void SortInventory()
    {
        for (int i = 0; i < _currentlyEquipped.Length; i++)
        {
            for (int j = i; j < _currentlyEquipped.Length; j++)
            {
                if (_currentlyEquipped[i]._value < _currentlyEquipped[j]._value)
                {
                    var temp = _currentlyEquipped[i];
                    _currentlyEquipped[i] = _currentlyEquipped[j];
                    _currentlyEquipped[j] = temp;
                }
            }
        }
    }
}
