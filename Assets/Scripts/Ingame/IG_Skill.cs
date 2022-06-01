using System;
using System.Collections.Generic;
using UnityEngine;

public class IG_Skill : MonoBehaviour, TriggerUpdateInterface
{
    //Skill dynamic stat
    private int cooldown;

    //Skill logic
    public void onClick()
    {
        //Click logic
    }

    //Use on significant state change(Advance move, turn, card played, etc...) in otherword about the same as status effect update
    public void doSkillLogic()
    {
        cooldown = Math.Min(cooldown--, 0);
    }
    //                                                  **********IMPLEMENTATION***********

    //Trigger Update
    public void triggerUpdate(HashSet<triggerTypes> triggers)
    {
        //Here come the if else madness

    }
}
