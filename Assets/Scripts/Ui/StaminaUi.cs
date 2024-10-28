using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaUi : PlayerCondition
{
    protected override void Awake()
    {

    }
    private void Update()
    {

        PassiveRecovery();


    }

    public void UpdateUi()
    {

        _image.fillAmount = currentValue / maxValue;
        
    }
    protected override void AddAmount(float amount)
    {
        base.AddAmount(amount);
        UpdateUi();
    }
    protected override void DecreaseAmount(float amount)
    {
        
        base.DecreaseAmount(amount);
        UpdateUi();
    }

    public void PassiveRecovery()
    {
        if(currentValue == maxValue) return;
        if(currentValue < maxValue)
        {
            currentValue += 0.01f;
        }
        UpdateUi();
    }

    public void SetAddStamina()   // ���׹̳��� ȸ���ϴ� �ż��� �ٸ� Ŭ�������� �����ü� �ְ�
    {
        AddAmount(amount);
    }
    public void SetDecreaseStamina()  // ���׹̳��� ���ҽ�Ű�� �ż��� �ٸ� Ŭ�������� �����ü� �ְ�
    {
       
        DecreaseAmount(10f);
    }
    
}
