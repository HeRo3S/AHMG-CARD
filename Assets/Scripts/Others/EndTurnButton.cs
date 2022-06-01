using UnityEngine;

public class EndTurnButton : MonoBehaviour, ClickableInterface
{
    private Controller controller;
    private bool canEdit = true;

    public void setController(Controller target)
    {
        if (canEdit)
        {
            controller = target;
            canEdit = false;
        }
    }
    public void onClick()
    {
        controller.addTrigger(triggerTypes.TURN_PASSED);
    }
}