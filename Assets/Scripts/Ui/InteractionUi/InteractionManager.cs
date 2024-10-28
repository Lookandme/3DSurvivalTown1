using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public float interactionDistance = 5.0f; // 상호 작용 거리
    public float chekLate = 0.1f;
    public float lastCheckTime;

    public GameObject curInteractGameObject;
    public LayerMask layerMask;
    private Camera camera;

    private void Start()
    {
        camera = Camera.main;
    }
    public void CheckInteract()
    {
        if (Time.time - lastCheckTime > chekLate)
        {
            lastCheckTime = Time.time;

            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactionDistance, layerMask))
            {
                if(hit.collider.gameObject != curInteractGameObject)
                {

                }
            }
        }

    }
}
