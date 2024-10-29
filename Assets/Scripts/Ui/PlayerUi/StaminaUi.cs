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




    public void SetAddStamina(float amount)   // 스테미나를 회복하는 매서드 다른 클래스에서 가져올수 있게
    {
        AddAmount(amount);
    }
    public void SetDecreaseStamina(float amount)  // 스테미나를 감소시키는 매서드 다른 클래스에서 가져올수 있게
    {

        DecreaseAmount(amount);
    }

}
