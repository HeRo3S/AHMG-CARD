using UnityEngine;

[CreateAssetMenu(fileName = "Draw", menuName = "AHMG-CARD/CharacterData/Sword Master/Cards/Draw", order = 0)]
public class Draw : CardTemplate
{
    public void OnEnable()
    {

        //Setting card base stat
        cardName = "Draw";
        cardDescription = "Draw 1 card";
        cardId = 8;
        rank = 1;
        cardType = cardTypes.UTILITY;
        baseCost = 4;
    }

    public override IG_Card createCard(IG_Player player)
    {
        IG_Card target = copyToIG();
        target.owner = player;
        //Card mechanic
        target.playCard = (IG_Player owner) =>
        {
            owner.drawCard(0,true);
        };
        return target;
    }
}