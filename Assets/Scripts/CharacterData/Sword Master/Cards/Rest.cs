using UnityEngine;

[CreateAssetMenu(fileName = "Rest", menuName = "AHMG-CARD/CharacterData/Sword Master/Cards/Rest", order = 0)]
public class Rest : CardTemplate
{
    public void OnEnable()
    {

        //Setting card base stat
        cardName = "Rest";
        cardDescription = "Restore " + baseHealPotency + " stamina";
        cardId = 7;
        rank = 1;
        cardType = cardTypes.UTILITY;
        baseCost = 0;
        baseStaminaPotency = 5;
    }

    public override IG_Card createCard(IG_Player player)
    {
        IG_Card target = copyToIG();
        target.owner = player;
        //Card mechanic
        target.playCard = (IG_Player owner) =>
        {
            owner.repenishStamina(target.staminaPotency);
        };
        return target;
    }
}