using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControl : MonoBehaviour {
    public float walkSpeed;
    public float rotateSpeed;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update() {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        // Handle walking both forward and backwards.
        // If walking backwards, reduce speed.
        if (v > 0) {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            transform.Translate(0, 0, forward.magnitude * (walkSpeed * v));
        } else if (v < 0) {
            Vector3 back = transform.TransformDirection(Vector3.back);
            transform.Translate(0, 0, back.magnitude * (walkSpeed * v) / 4);
        }

        // Rotate model when L/R is pressed.
        transform.Rotate(0, h * rotateSpeed, 0);
    }
}
