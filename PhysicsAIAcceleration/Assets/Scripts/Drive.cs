﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public Transform transGun;
    public Transform gun;
    public GameObject bulletObj;

    void Update() {
   
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

    
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

       
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetKey(KeyCode.T)) {

            transGun.RotateAround(transGun.position, transGun.right, -2.0f);
        } else if (Input.GetKey(KeyCode.G)) {

            transGun.RotateAround(transGun.position, transGun.right, 2.0f);
        } else if (Input.GetKeyDown(KeyCode.B)) {

            Instantiate(bulletObj, gun.position, gun.rotation);
        }
    }
}
