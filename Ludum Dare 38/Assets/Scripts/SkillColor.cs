using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillColor : MonoBehaviour {

    private Skill skill;
	void Start () {
        skill = GetComponent<Skill>();
	}

	void Update () {
        if(skill.TimeCoolDown != 0)
        {
            GetComponent<RawImage>().color = Color.red;
        }else
        {
            GetComponent<RawImage>().color = Color.white;
        }
    }
}
