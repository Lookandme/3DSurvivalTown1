using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUi : PlayerCondition
{
    protected override void Awake()
    {
        
    }
    private void Update()
    {
        _image.fillAmount = currentValue / maxValue;
    }

    protected override void AddAmount(float amount)
    {
        if (currentValue  < maxValue)
        {
           currentValue = maxValue;
        }
        else
        {
            currentValue += amount;
        }
    }
    protected override void DecreaseAmount(float amount)
    {
        if (currentValue < minValue)
        {
            currentValue = minValue;
        }
        else
        {
            currentValue -= amount;
        }
    }
}
