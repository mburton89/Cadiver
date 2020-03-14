using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : Collectible
{
    [SerializeField]
    private float _mass;

    public override void GetCollected(Cadiver cadiver)
    {
        TreasureManager.Instance.IncrementCollectedCoinCount();
        cadiver.AddDownwardForce(_mass);
    }
}
