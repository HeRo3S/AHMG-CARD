using UnityEngine;

[CreateAssetMenu(fileName = "Rapid Needle", menuName = "AHMG-CARD/CharacterData/Sword Master/Cards/Rapid Needle", order = 0)]
public class RapidNeedle : CardTemplate
{
    public void OnEnable()
    {

        //Setting card base stat
        cardName = "Rapid Needle";
        cardId = 5;
        rank = 1;
        cardType = cardTypes.ATTACK;
        baseCost = 10;
        basePhysicalDmg = 5;
        baseMagicDmg = 0;
        cardDescription = "Deal" + basePhysicalDmg + "physical damage 8 time";
    }

    public override IG_Card createCard(IG_Player player)
    {
        IG_Card target = copyToIG();
        target.owner = player;
        //Card mechanic
        target.playCard = (IG_Player owner) =>
        {
            for(int i = 0; i < 8; i++){
                owner.getOpponent().receivePhysicalDmg(target.physicalDmg);
            }
        };
        return target;
    }
}