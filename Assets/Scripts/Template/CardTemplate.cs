using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class CardTemplate : ScriptableObject
{
    //Card info
    public string cardName;
    public string cardDescription;
    public string cardId;
    public int rank;
    protected cardTypes cardType;
    //Base stat
    internal int baseCost;
    internal int basePhysicalDmg;
    internal int baseMagicDmg;
    public delegate void cardDelegate(IG_Player owner);
    public cardDelegate playCard;
    //Copy current card info to new one
       public GameObject IGcardObj;
    //UI stats
    public Text name;
    protected IG_Card copyToIG(){
        IGcardObj = Resources.Load<GameObject>("Handmade assets/Card") as GameObject;
        GameObject cardObj = Instantiate(IGcardObj);
        //UI Setup
        name = cardObj.transform.GetChild(0).GetChild(1).gameObject.GetComponent<Text>();
        name.text = cardName;
        //
        IG_Card target = cardObj.AddComponent<IG_Card>();
        target.baseCard = this;
        return target;
    }
    
    //Function to create IG_Card
    public virtual IG_Card createCard(IG_Player player){
        return null;
    }
}
