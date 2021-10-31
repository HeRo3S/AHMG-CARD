using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG_Card : CardTemplate
{
    //Card dynamic stat
    private int cost;
    private int physicalDmg;
    private int magicDmg;
    //Other variable
    private IG_Player owner;
    private IG_Deck deck;

    //Card logic
    public void onClick(){
        playCard(owner);
    }

    //Use on significant state change(Advance move, turn, card played, etc...) in otherword about the same as status effect update
    public void doCardLogic(){
        physicalDmg = basePhysicalDmg;
        cost = baseCost;
        magicDmg = baseMagicDmg;
    }

}
