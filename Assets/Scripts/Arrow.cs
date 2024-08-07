﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int damageAmount = 20;

    private void Start()
    {
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if(other.tag == "Bear")
        {
            transform.parent = other.transform;
            other.GetComponent<Bear>().TakeDamage(damageAmount);
        }
    }
}
