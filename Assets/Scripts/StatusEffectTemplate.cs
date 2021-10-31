using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatusEffectTemplate : MonoBehaviour
{
    //Status effect info
    public string statusName;
    public string statusDescription;
    public statusTypes statusType;
    //Status effect stat
    protected int statusLife;
    protected int statusDuration;

    //Status effect logic
    protected delegate void statusEfxDelegate(IG_Player owner, List<triggerTypes> triggers);
    protected statusEfxDelegate dostatusEfx;
}
