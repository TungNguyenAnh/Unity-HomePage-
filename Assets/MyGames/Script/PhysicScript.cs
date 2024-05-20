using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhysicScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Dang va cham!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Ket thuc va cham!");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bat dau va cham trigger!");
        Debug.Log(other.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("dang va cham trigger!");
        Debug.Log(other.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("ket thuc va cham trigger!");
        Debug.Log(other.name);
    }
}
