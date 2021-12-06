using UnityEngine;

[CreateAssetMenu(fileName = "Heal", menuName = "AHMG-CARD/CharacterData/Sword Master/Cards/Heal", order = 0)]
public class Heal : CardTemplate
{
    public void OnEnable()
    {

        //Setting card base stat
        cardName = "Heal";
        cardId = 6;
        rank = 1;
        cardType = cardTypes.SUPPORT;
        baseCost = 3;
        baseHealPotency = 15;
        cardDescription = "Heal by " + baseHealPotency;
    }

    public override IG_Card createCard(IG_Player player)
    {
        IG_Card target = copyToIG();
        target.owner = player;
        //Card mechanic
        target.playCard = (IG_Player owner) =>
        {
            owner.heal(target.healPotency);
        };
        return target;
    }
}