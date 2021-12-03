using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Controller : MonoBehaviour
{
    private HashSet<triggerTypes> triggers;
    private List<IG_Player> players;

    private List<Text> healthDisplay;
    private List<Text> staminaDisplay;
    private BattleHistory battleHistory = new BattleHistory();
    private bool finished = false;
    private int turn;
    private int card_order;

    //Testing end turn button

    public void Start()
    {
        turn = 0;

        GameObject endTurnBtn = Instantiate(Resources.Load<GameObject>("Handmade assets/Card") as GameObject);
        EndTurnButton endTurnButton = endTurnBtn.AddComponent<EndTurnButton>() as EndTurnButton;
        endTurnButton.setController(this);


        players = new List<IG_Player>();
        triggers = new HashSet<triggerTypes>();


        TestDeck testDeck = Resources.Load<TestDeck>("AHMG-CARD/TestDeck") as TestDeck;
        SwordMasterChar testChar = ScriptableObject.CreateInstance("SwordMasterChar") as SwordMasterChar;


        players.Add(testChar.createPlayer(testDeck));
        players.Add(testChar.createPlayer(testDeck));
        players[0].setOpponent(players[1]);
        players[1].setOpponent(players[0]);
        players[0].setTurn(false);
        players[1].setTurn(true);
        players[0].setController(this);
        players[1].setController(this);

        endTurnButton.onClick();

        //UI elements
        players[0].setRenderPosition(0);
        players[1].setRenderPosition(1);
        healthDisplay = new List<Text>();
        staminaDisplay = new List<Text>();

        healthDisplay.Add(GameObject.Find("UI/Canvas/Player/Health").GetComponent<Text>());
        staminaDisplay.Add(GameObject.Find("UI/Canvas/Player/Stamina").GetComponent<Text>());
        healthDisplay.Add(GameObject.Find("UI/Canvas/Enemy/Health").GetComponent<Text>());
        staminaDisplay.Add(GameObject.Find("UI/Canvas/Enemy/Stamina").GetComponent<Text>());

        //Set up battle history JSON
        battleHistory.player1_id = 1;
        battleHistory.player2_id = 1;
        battleHistory.deck1_id = 1;
        battleHistory.deck2_id = 1;

    }
    //Add trigger
    public void addTrigger(triggerTypes target)
    {
        triggers.Add(target);
    }

    //Update battle move

    public void addBattleMove(int card_id)
    {
        battleHistory.addMove(new BattleMove(card_order, turn, card_id));
        card_order++;
    }

    //Function to end game
    public void endGame(int winner)
    {
        battleHistory.winner = winner;
        string result = JsonUtility.ToJson(battleHistory);
        StartCoroutine(Upload(result));
        finished = true;
    }

    //Send data
    IEnumerator Upload(String data)
    {
        byte[] myData = System.Text.Encoding.UTF8.GetBytes(data);
        UnityWebRequest www = UnityWebRequest.Put("http://localhost:3000/ahmg_card_data/send_battle_result", myData);
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            UnityEngine.Debug.Log(www.error);
            www.Dispose();
        }
        else
        {
            UnityEngine.Debug.Log("Upload complete!");
            www.Dispose();
        }
    }

    public void Update()
    {
        //Check if an object is clicked on
        if (Input.GetMouseButtonDown(0) && !finished)
        {
            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Get game object script
                ClickableInterface target = hit.transform.gameObject.GetComponent(typeof(ClickableInterface)) as ClickableInterface;
                if (target != null)
                {
                    target.onClick();
                }
            }
        }
        healthDisplay[0].text = "HEALTH: " + players[0].getHealthPts();
        staminaDisplay[0].text = "STAMINA: " + players[0].getStaminaPts();
        healthDisplay[1].text = "HEALTH: " + players[1].getHealthPts();
        staminaDisplay[1].text = "STAMINA: " + players[1].getStaminaPts();
    }

    void LateUpdate()
    {
        if (triggers.Count > 0)
        {
            if (triggers.Contains(triggerTypes.TURN_PASSED))
            {
                turn++;
                card_order = 1;
            }
            foreach (IG_Player player in players)
            {
                player.triggerUpdate(triggers);
            }
        }
        triggers.Clear();
    }
}