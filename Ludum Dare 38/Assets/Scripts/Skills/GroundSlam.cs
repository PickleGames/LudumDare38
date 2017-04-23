using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSlam : Skill {


    public Collider2D attackTrigger;

    void Start()
    {

    }

    void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Use();
        }
    }

    public override void Function()
    { 

    }
}
