using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepAnimationController : ZepAnimations
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    protected override void Awake()
    {
        base.Awake();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > .5f);
    }
}
