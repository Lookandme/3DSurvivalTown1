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
        PassiveRecovery();
    }

    public override void PassiveRecovery() => base.PassiveRecovery();


    protected override void AddAmount(float amount)
    {
        base.AddAmount(amount);

    }
    protected override void DecreaseAmount(float amount)
    {
        base.DecreaseAmount(amount);
    }

    public void SetAddHealth()   // 체력를 회복하는 매서드 다른 클래스에서 가져올수 있게 하는 매서드
    {
        AddAmount(amount);
    }
    public void SetDecreaseHealth()  // 체력를 감소시키는 매서드 다른 클래스에서 가져올수 있게 하는 매서드
    {
        DecreaseAmount(amount);
    }
}
