
[System.Serializable]

public class BattleMove
{
    public int order;
    public int turn;
    public int card_id;

    public BattleMove(int order, int turn, int card_id)
    {
        this.order = order;
        this.turn = turn;
        this.card_id = card_id;
    }
}