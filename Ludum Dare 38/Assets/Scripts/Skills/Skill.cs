using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour {

    public float defaultCoolDown;
    public GameObject player;
    private float timeCoolDown;
    private bool IsUse;
    private bool IsUsable;

    void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
        if (IsUse)
        {
            if(timeCoolDown >= defaultCoolDown)
            {
                IsUsable = true;
                IsUse = false;
            }
            timeCoolDown += Time.deltaTime;
        }
	}

    public void Use() {
        IsUse = true;
    }

    public abstract void Function();

}
