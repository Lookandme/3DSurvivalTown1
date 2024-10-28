using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public PlayerController controller;
    public ItemData ItemData;
    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        CharacterManager.Instance.Player = this;
    }
}
