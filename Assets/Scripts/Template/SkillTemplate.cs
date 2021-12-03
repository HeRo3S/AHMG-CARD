using UnityEngine;

public abstract class SkillTemplate : ScriptableObject
{
    //Skill info
    protected string skillName;
    protected string skillDescription;
    protected skillTypes skillType;

    //Base stat
    protected int baseCD;
    protected delegate void skillDelegate(IG_Player target);
    protected skillDelegate doSkill;
}
