using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    private bool isDragged;

    private void OnMouseDown() {
        isDragged = true;
    }

    private void OnMouseUp() {
        isDragged = false;
    }

    private void Start() {
        FixedJoint2D joint = gameObject.GetComponent(typeof(FixedJoint2D)) as FixedJoint2D;
        joint.autoConfigureConnectedAnchor = true;
        joint.autoConfigureConnectedAnchor = false;
    }

    void Update()
    {
        if(isDragged) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
    }
}
