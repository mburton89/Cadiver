using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreasureManager : MonoBehaviour
{
    public static TreasureManager Instance;
    private int _collectedTreasure;
    public TextMeshProUGUI treasureCount;

    private void Awake()
    {
        Instance = this;
        DisplayCoinCount();
    }

    void DisplayCoinCount()
    {
        treasureCount.SetText(_collectedTreasure.ToString());
    }

    public void IncrementCollectedCoinCount()
    {
        _collectedTreasure++;
        DisplayCoinCount();
    }
}