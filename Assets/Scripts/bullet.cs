using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] float velocity;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        rigidbody.velocity = this.transform.forward * velocity;
    }
}
