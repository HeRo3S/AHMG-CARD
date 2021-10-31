using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkillTemplate : MonoBehaviour
{
    //Skill info
    public string skillName;
    public string skillDescription;
    public skillTypes skillType;

    //Base stat
    protected int baseCD;
    protected delegate void skillDelegate(IG_Player target);
    protected skillDelegate doSkill;
}
