using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepAnimations : MonoBehaviour
{
    protected Animator animator;
    protected ZepCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<ZepCharacterController>();
    }
}