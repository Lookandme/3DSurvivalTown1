using System.Collections;
using UnityEngine;

public class HealthUi : PlayerCondition
{
    public int blinkCount;
    public GameObject TakeDamage;
    public bool takingDamage = false;
    


    protected override void Awake()
    {

    }
    private void Update()
    {
        PassiveRecovery();
    }

    public override void PassiveRecovery() => base.PassiveRecovery();

    protected override void AddAmount(float amount) => base.AddAmount(amount);

    protected override void DecreaseAmount(float amount)
    {
        base.DecreaseAmount(amount);

    }

    public IEnumerator BlinkDamageUI()
    {

        while (takingDamage == true)
        {
            TakeDamage.SetActive(true);
            yield return new WaitForSeconds(1f); // 활성화 시간
            TakeDamage.SetActive(false);                                 // 체력이 감소하는 코드 구현 /수정 필요 , 화면 깜빡이는 코드 구현 / 수정필요 
            yield return new WaitForSeconds(1f); // 비활성화 시간
        }
        TakeDamage.SetActive(false);



    }

    public void TakeDamageUi()
    {
        StartCoroutine(BlinkDamageUI());
        Debug.Log("a");
    }

    public void SetAddHealth(float amount)   // 체력를 회복하는 매서드 다른 클래스에서 가져올수 있게 하는 매서드
    {
        AddAmount(amount);
    }
    public void SetDecreaseHealth(float amount)  // 체력를 감소시키는 매서드 다른 클래스에서 가져올수 있게 하는 매서드
    {
        takingDamage = true;
        DecreaseAmount(amount);

    }


}
