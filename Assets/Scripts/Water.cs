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

                // 데미지가 들어오는 코드 자리

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
        // 물속에 있는거 처럼 구현 할 것

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
