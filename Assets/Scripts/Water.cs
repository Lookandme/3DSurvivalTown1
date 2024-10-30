using UnityEngine;

public class Water : MonoBehaviour
{
   
    public HealthUi healthUi;
    public GameObject InWater;
    public float timer = 0f;
    public float underWater = 10f;
    public bool inWater = false;



    private void Update()
    {
        UnderWater();
       
      
        if (inWater == true)
        {
            timer += Time.deltaTime;
            if (timer > underWater)
            {

                // �������� ������ �ڵ� �ڸ�

                healthUi.SetDecreaseHealth(0.01f);
                //healthUi.TakeDamageUi();
            }
                
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            if (other.transform.position.y < -2)
            {
                inWater = true;
                

            }
            else
            {
                inWater = false;
                timer = 0f;
            }
        }
    }



    private void UnderWater()
    {
        // ���ӿ� �ִ°� ó�� ���� �� ��

        if (inWater == true)
        {
            InWater.SetActive(true);
           
        }
        else
        {
            InWater.SetActive(false);
        }




    }


}
