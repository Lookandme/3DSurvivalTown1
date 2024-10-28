using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "New ItemData")]
public class ItemData : ScriptableObject
{
    public enum ItemType
    {
        Resource,
        Equipable,
        Consumable
    }
    public enum ConsumableType
    {
        Health,
        Stamina
    }

    [SerializeField]
    public class ItemDataConsumable
    {
        public ConsumableType type;
        public float value;
    }

    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;

    [Header("Quantity")]
    public bool canStack;
    public int maxQuantityAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
}
