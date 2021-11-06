using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stab : CardTemplate
{
    public void Start(){

        //Setting card base stat
        cardName = "Stab";
        cardDescription = "Deal" + basePhysicalDmg + "physical damage";
        cardId = "0000";
        rank = 1;
        cardType = cardTypes.ATTACK;
        baseCost = 3;
        basePhysicalDmg = 8;
        baseMagicDmg = 0;
    }

    public override IG_Card createCard(IG_Player player){
        IG_Card target = copyToIG();
        target.owner = player;
        //Card mechanic
        target.playCard = (IG_Player owner) =>{
            owner.getOpponent().receivePhysicalDmg(target.physicalDmg);
        };
        return target;
    }
}