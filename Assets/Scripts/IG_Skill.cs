using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class IG_Skill : SkillTemplate{
    //Skill dynamic stat
    private int cooldown;

    //Skill logic
    public void onClick(){
        //Click logic
    }

    //Use on significant state change(Advance move, turn, card played, etc...) in otherword about the same as status effect update
    public void doSkillLogic(){
        cooldown = Math.Min(cooldown--, 0);
    }

}
