using UnityEngine;

[CreateAssetMenu(fileName = "Slash", menuName = "AHMG-CARD/CharacterData/Sword Master/Cards/Slash", order = 0)]
public class Slash : CardTemplate
{
    public void OnEnable()
    {

        //Setting card base stat
        cardName = "Slash";
        cardId = 4;
        rank = 1;
        cardType = cardTypes.ATTACK;
        baseCost = 6;
        basePhysicalDmg = 20;
        baseMagicDmg = 0;
        cardDescription = "Deal" + basePhysicalDmg + "physical damage";
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