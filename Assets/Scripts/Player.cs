using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    Rigidbody myRB;
    private void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed * Time.deltaTime;
        transform.position += velocity;
        
    }
}

////////
