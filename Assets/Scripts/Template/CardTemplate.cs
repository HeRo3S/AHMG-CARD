using UnityEngine;
using UnityEngine.UI;

public abstract class CardTemplate : ScriptableObject
{
    //Card info
    protected string cardName;
    protected string cardDescription;
    protected int cardId;
    protected int rank;
    protected cardTypes cardType;
    //Base stat
    protected int baseCost;
    protected int basePhysicalDmg;
    protected int baseMagicDmg;
    protected int baseHealPotency;
    protected int baseStaminaPotency;
    //Copy current card info to new one
    public GameObject IGcardObj;
    //Getter
    internal string getName()
    {
        return cardName;
    }

    internal string getDescription()
    {
        return cardDescription;
    }

    internal int getId()
    {
        return cardId;
    }

    internal int getRank()
    {
        return rank;
    }

    internal cardTypes getType()
    {
        return cardType;
    }

    internal int getBaseCost()
    {
        return baseCost;
    }

    internal int getBasePhysicalDmg()
    {
        return basePhysicalDmg;
    }

    internal int getBaseMagicalDmg()
    {
        return baseMagicDmg;
    }

    internal int getBaseHealPotency(){
        return baseHealPotency;
    }
    internal int getBaseStaminaPotency(){
        return baseStaminaPotency;
    }

    protected IG_Card copyToIG()
    {
        IGcardObj = Resources.Load<GameObject>("Handmade assets/Card") as GameObject;
        GameObject cardObj = Instantiate(IGcardObj);
        //UI Setup
        Text name = cardObj.transform.GetChild(0).GetChild(1).gameObject.GetComponent<Text>() as Text;
        name.text = cardName + '\n' + cardDescription;
        //
        IG_Card target = cardObj.AddComponent<IG_Card>();
        target.baseCard = this;
        return target;
    }

    //Function to create IG_Card
    public virtual IG_Card createCard(IG_Player player)
    {
        return null;
    }
}
