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

    public void SetAddStamina()   // 스테미나를 회복하는 매서드 다른 클래스에서 가져올수 있게
    {
        AddAmount(amount);
    }
    public void SetDecreaseStamina()  // 스테미나를 감소시키는 매서드 다른 클래스에서 가져올수 있게
    {
       
        DecreaseAmount(10f);
    }
    
}
