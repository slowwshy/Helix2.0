using System;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    private new Rigidbody RB;
    public float bounceForce = 6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().linearVelocity = new Vector3(RB.linearVelocity.x, bounceForce, RB.linearVelocity.y);
    }
}
