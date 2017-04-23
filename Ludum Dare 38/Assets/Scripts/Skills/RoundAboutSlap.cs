using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundAboutSlap : Skill {

    public Collider2D attackTrigger;

    void Start()
    {
        attackTrigger.enabled = false;
    }

    void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Use();
        }

        if (IsUse)
        {
            attackTrigger.enabled = true;
        }

        if (TimeCoolDown > 3)
        {
            attackTrigger.enabled = false;
        }
    }

    public override void Function()
    {
       
    }
}
