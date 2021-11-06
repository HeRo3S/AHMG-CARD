using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardTemplate : MonoBehaviour
{
    //Card info
    public string cardName;
    public string cardDescription;
    public string cardId;
    public int rank;
    protected cardTypes cardType;
    //Base stat
    protected int baseCost;
    protected int basePhysicalDmg;
    protected int baseMagicDmg;
    //Card mechanic
    public delegate void cardDelegate(IG_Player owner);
    public cardDelegate playCard;

    //Copy current card info to new one
    protected IG_Card copyToIG(){
        IG_Card target = new IG_Card();
        target.cardName = this.cardName;
        target.cardDescription = this.cardDescription;
        target.cardId = this.cardId;
        target.rank = this.rank;
        target.cardType = this.cardType;
        target.baseCost = this.baseCost;
        target.basePhysicalDmg = this.basePhysicalDmg;
        target.baseMagicDmg = this.baseMagicDmg;
        return target;
    }
    
    //Function to create IG_Card
    public virtual IG_Card createCard(IG_Player player){
        return null;
    }
}
