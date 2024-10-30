public class StaminaUi : PlayerCondition
{
    protected override void Awake()
    {

    }
    private void Update()
    {
        AddAmount(0.01f);
    }



    
    protected override void AddAmount(float amount) => base.AddAmount(amount);
    protected override void DecreaseAmount(float amount) => base.DecreaseAmount(amount);




    public void SetAddStamina(float amount)   // ���׹̳��� ȸ���ϴ� �ż��� �ٸ� Ŭ�������� �����ü� �ְ�
    {
        AddAmount(amount);
    }
    public void SetDecreaseStamina(float amount)  // ���׹̳��� ���ҽ�Ű�� �ż��� �ٸ� Ŭ�������� �����ü� �ְ�
    {

        DecreaseAmount(amount);
    }

}
