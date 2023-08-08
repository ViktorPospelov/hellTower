using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody _rigiBody;
    private Animator _animation;
    public float speed = 2f;

    void Start()
    {
        _animation = GetComponent<Animator>();
        _rigiBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float v = Input.GetAxis("Horizontal");
        float h = Input.GetAxis("Vertical");

        Vector3 directionVector = new Vector3(v, 0, h);
        _animation.SetFloat("moveSpeed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        _rigiBody.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
    }
}