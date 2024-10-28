using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCondition : MonoBehaviour
{
    public Image _image;

    [Header("UserCondition")]

    protected float amount = 0f; // ���ϴ� ��ġ
    protected float currentValue = 100f; // ���� ��ġ
    protected float maxValue = 100f;  // �ִ� ��ġ
    protected float minValue = 0f;  // �ּ� ��ġ

    protected virtual void Awake()
    {
       
    }

    public virtual void UpdateUi()
    {
        _image.fillAmount = currentValue / maxValue;
    }

    public virtual void PassiveRecovery()
    {
        if (currentValue == maxValue) return;
        if (currentValue < maxValue)
        {
            currentValue += 0.01f;
        }
        UpdateUi();
    }

    protected virtual void AddAmount(float amount)
    {
        currentValue += amount;

        if (currentValue < maxValue)
        {
            currentValue = maxValue;
        }
        UpdateUi();
    }
    protected virtual void DecreaseAmount(float amount)
    {
            currentValue -= amount;
        if (currentValue < minValue)
        {
            currentValue = minValue;
        }
        UpdateUi();
    }
}
