using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG_Card : CardTemplate
{
    //Card dynamic stat
    internal int cost;
    internal int physicalDmg;
    internal int magicDmg;
    //Other variable
    internal IG_Player owner;
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
