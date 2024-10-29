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
            yield return new WaitForSeconds(1f); // Ȱ��ȭ �ð�
            TakeDamage.SetActive(false);                                 // ü���� �����ϴ� �ڵ� ���� /���� �ʿ� , ȭ�� �����̴� �ڵ� ���� / �����ʿ� 
            yield return new WaitForSeconds(1f); // ��Ȱ��ȭ �ð�
        }
        TakeDamage.SetActive(false);



    }

    public void TakeDamageUi()
    {
        StartCoroutine(BlinkDamageUI());
        Debug.Log("a");
    }

    public void SetAddHealth(float amount)   // ü�¸� ȸ���ϴ� �ż��� �ٸ� Ŭ�������� �����ü� �ְ� �ϴ� �ż���
    {
        AddAmount(amount);
    }
    public void SetDecreaseHealth(float amount)  // ü�¸� ���ҽ�Ű�� �ż��� �ٸ� Ŭ�������� �����ü� �ְ� �ϴ� �ż���
    {
        takingDamage = true;
        DecreaseAmount(amount);

    }


}
