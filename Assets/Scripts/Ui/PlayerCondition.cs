using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCondition : MonoBehaviour
{
    public Image _image;

    [Header("UserCondition")]

    protected float amount = 0f; // 변하는 수치
    protected float currentValue = 100f; // 현재 수치
    protected float maxValue = 100f;  // 최대 수치
    protected float minValue = 0f;  // 최소 수치

    protected virtual void Awake()
    {
       
    }

    protected virtual void AddAmount(float amount)
    {
        currentValue += amount;

        if (currentValue < maxValue)
        {
            currentValue = maxValue;
        }
        
    }
    protected virtual void DecreaseAmount(float amount)
    {
            currentValue -= amount;
        if (currentValue < minValue)
        {
            currentValue = minValue;
        }
       
    }
}
