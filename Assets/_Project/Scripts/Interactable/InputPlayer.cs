using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    [SerializeField] private LayerMask _interactableLayer;

  

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit,Mathf.Infinity,_interactableLayer))
            {

                Debug.Log(hit.collider.name);
                if (hit.collider.GetComponent<InteractableObject>() != null)
                    hit.collider.GetComponent<InteractableObject>().Interact();
            }

        }

        
    }
}
