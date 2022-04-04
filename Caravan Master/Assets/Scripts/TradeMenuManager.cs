using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeMenuManager : MonoBehaviour
{

    public float tradeInterval = 10;
    private float tradeTimer;

    void Ready()
    {
        tradeTimer = tradeInterval;
    }

    void Update()
    {
        tradeTimer -= Time.deltaTime;

        if (tradeTimer <= 0){
            tradeTimer = tradeInterval;
            NewTrade();
        }
    }

    void NewTrade()
    {
        
    }
}
