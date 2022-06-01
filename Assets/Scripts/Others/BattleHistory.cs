
using System.Collections.Generic;


[System.Serializable]

public class BattleHistory
{
    public int player1_id;
    public int player2_id;
    public int deck1_id;
    public int deck2_id;
    public int winner;
    public List<BattleMove> battleMoves = new List<BattleMove>();

    public void addMove(BattleMove move)
    {
        battleMoves.Add(move);
    }
}