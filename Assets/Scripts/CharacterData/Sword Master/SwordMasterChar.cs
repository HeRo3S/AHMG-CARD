using UnityEngine;

[CreateAssetMenu(fileName = "SwordMasterChar", menuName = "AHMG-CARD/CharacterData/Sword Master/SwordMasterChar", order = 0)]
public class SwordMasterChar : CharacterTemplate
{
    public void OnEnable()
    {
        //Character info
        characterName = "Sword Master";
        characterId = 1;
        characterDescription = "?";

        //Character stat
        fixed_maxHp = 350;
        fixed_staminaRegen = 30;
    }

    public override IG_Player createPlayer(DeckTemplate deck)
    {
        IG_Player target = copyToIG();
        target.deck = deck.createDeck();
        target.deck.owner = target;
        return target;
    }
}