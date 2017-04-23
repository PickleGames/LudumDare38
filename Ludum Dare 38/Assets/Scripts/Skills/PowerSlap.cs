using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSlap : Skill {

    public Collider2D attackTrigger;

    void Start()
    {
        attackTrigger.enabled = false;
    }

    void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Use();
        }

        if (IsUse)
        {
            attackTrigger.enabled = true;
        }

        if (TimeCoolDown > 0.5)
        {
            attackTrigger.enabled = false;
        }
    }

    public override void Function()
    {

    }
}
