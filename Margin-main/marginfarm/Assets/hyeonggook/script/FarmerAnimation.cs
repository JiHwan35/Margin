﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.Play("Standing");
    }
}
