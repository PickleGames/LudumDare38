using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slap : Skill {

    public float strength;
    public Collider2D attackTrigger;

    void Start()
    {
        attackTrigger.enabled = false;
    }

    void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Space))
        {
            Use();
        }

        if (IsUse)
        {
            attackTrigger.enabled = true;
        }
        else
        {
            attackTrigger.enabled = false;
        }
    }

    public override void Function()
    {
        
    }

}
