public class StaminaUi : PlayerCondition
{
    protected override void Awake()
    {

    }
    private void Update()
    {
        PassiveRecovery();
    }



    public override void PassiveRecovery() => base.PassiveRecovery();
    protected override void AddAmount(float amount) => base.AddAmount(amount);
    protected override void DecreaseAmount(float amount) => base.DecreaseAmount(amount);




    public void SetAddStamina()   // ���׹̳��� ȸ���ϴ� �ż��� �ٸ� Ŭ�������� �����ü� �ְ�
    {
        AddAmount(amount);
    }
    public void SetDecreaseStamina()  // ���׹̳��� ���ҽ�Ű�� �ż��� �ٸ� Ŭ�������� �����ü� �ְ�
    {

        DecreaseAmount(10f);
    }

}
