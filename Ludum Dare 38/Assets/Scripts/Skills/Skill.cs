﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour {

    public float defaultCoolDown;
    public GameObject target;
    private float timeCoolDown;
    public bool IsUse;

    private bool IsUsable;

    public void Awake () {
        IsUsable = true;
        IsUse = true;
        Debug.Log("deeznt");
	}
	
	// Update is called once per frame
	public void Update () {
        //Debug.Log("tc: " + timeCoolDown);
        //Debug.Log("isUse " + IsUse);
        //Debug.Log("usable" + IsUsable);
        if (IsUse)
        {
            timeCoolDown += Time.deltaTime;
            if(timeCoolDown >= defaultCoolDown)
            {
                IsUsable = true;
                IsUse = false;
                timeCoolDown = 0;
            }            
        }
	}

    public void Use() {
        if (IsUsable)
        {
            IsUse = true;
            IsUsable = false;
        }
    }

    public abstract void Function();


}
