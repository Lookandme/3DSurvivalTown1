using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCondition : MonoBehaviour
{
    public Image _image;
   

    [Header("UserCondition")]
    protected float amount = 0f; // ���ϴ� ��ġ
    protected float currentValue = 100f; // ���� ��ġ
    protected float maxValue = 100f;  // �ִ� ��ġ
    protected float minValue = 0f;  // �ּ� ��ġ
    

    protected virtual void Awake()
    {
       
    }

    public virtual void UpdateUi()
    {
        _image.fillAmount = currentValue / maxValue;
    }

    

    protected virtual void AddAmount(float amount)
    {

       
        if (currentValue > maxValue)
        {
            currentValue = maxValue;
        }
        else
        {
            currentValue += amount;
        }
        UpdateUi();

    }
    protected virtual void DecreaseAmount(float amount)
    {
       

        if (currentValue < minValue)
        {
            currentValue = minValue;
        }
        else
        {
            currentValue -= amount;
        }
        UpdateUi();

    }

    


}
