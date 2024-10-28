using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionManager : MonoBehaviour
{
    public float interactionDistance = 5.0f; // 상호 작용 거리
    public float chekLate = 0.05f;
    public float lastCheckTime;

    public GameObject curInteractGameObject;
    private IInteractable curInteractable;
    public LayerMask layerMask;
    private Camera camera;
    public TextMeshProUGUI promptText; 

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        CheckInteract();
    }
    public void CheckInteract()
    {
        if (Time.time - lastCheckTime > chekLate)
        {
            lastCheckTime = Time.time;

            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            RaycastHit hit;
            Debug.DrawRay(ray.origin,ray.direction);

            if (Physics.Raycast(ray, out hit, interactionDistance, layerMask))
            {
                if(hit.collider.gameObject != curInteractGameObject)
                {
                    curInteractGameObject = hit.collider.gameObject;
                    curInteractable = hit.collider.GetComponent<IInteractable>();
                    SetPrompt();
                }
            }
            else
            {
                curInteractGameObject = null;
                curInteractable = null;
                promptText.gameObject.SetActive(false);
            }
        }

    }
    private void SetPrompt()
    {
        promptText.gameObject.SetActive(true);
        promptText.text = curInteractable.GetInteractPrompt();
    }
}
