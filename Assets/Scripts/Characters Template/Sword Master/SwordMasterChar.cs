using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMasterChar : CharacterTemplate
{
    public void Start(){
        //Character info
        characterName = "Sword Master";
        characterId = "00";
        characterDescription = "?";

        //Character stat
        fixed_maxHp = 350;
        fixed_staminaRegen = 30;
    }

    public override IG_Player createPlayer(IG_Player opponent)
    {
        IG_Player target = copyToIG();
        target.setOpponent(opponent);
        return target;
    }
}