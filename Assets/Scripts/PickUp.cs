using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PickUp : MonoBehaviour
{
    private bool picked_up = false;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (picked_up) {
            ObjectPickedUp();
    }
        else {
        ObjectPlacedDown();
    }

    }

    private void ObjectPickedUp() {
        picked_up = true;
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;
        transform.position = mousePos;
    }

    private void ObjectPlacedDown() {
        picked_up = false;
        transform.position = startPosition;
    }
    private void OnMouseDown() {
        if (picked_up) {
            picked_up = false;
        }
        else {
            picked_up = true;
        }

    }

}
