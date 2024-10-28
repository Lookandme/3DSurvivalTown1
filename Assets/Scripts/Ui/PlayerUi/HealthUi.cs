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

    public void SetAddHealth()   // ü�¸� ȸ���ϴ� �ż��� �ٸ� Ŭ�������� �����ü� �ְ� �ϴ� �ż���
    {
        AddAmount(amount);
    }
    public void SetDecreaseHealth()  // ü�¸� ���ҽ�Ű�� �ż��� �ٸ� Ŭ�������� �����ü� �ְ� �ϴ� �ż���
    {
        DecreaseAmount(amount);
    }
}
