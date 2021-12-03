using UnityEngine;

[CreateAssetMenu(fileName = "Stab", menuName = "AHMG-CARD/CharacterData/Sword Master/Cards/Stab", order = 0)]
public class Stab : CardTemplate
{
    public void OnEnable()
    {

        //Setting card base stat
        cardName = "Stab";
        cardDescription = "Deal" + basePhysicalDmg + "physical damage";
        cardId = 3;
        rank = 1;
        cardType = cardTypes.ATTACK;
        baseCost = 3;
        basePhysicalDmg = 8;
        baseMagicDmg = 0;
    }

    public override IG_Card createCard(IG_Player player)
    {
        IG_Card target = copyToIG();
        target.owner = player;
        //Card mechanic
        target.playCard = (IG_Player owner) =>
        {
            owner.getOpponent().receivePhysicalDmg(target.physicalDmg);
        };
        return target;
    }
}