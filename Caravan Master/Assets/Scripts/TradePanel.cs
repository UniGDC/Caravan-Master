using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradePanel : MonoBehaviour
{
    private string location;
    private string item;
    private string price;

    private float maxDuration;
    private float currentDuration; //in seconds in the future


    void SetTrade(string _location, string _item, int _price, float _duration) // Runs when the trade is initially created
    {
        location = _location;
        item = _item;
        price = _price.ToString();

        maxDuration = _duration;
        currentDuration = maxDuration;
    }

    void FixedUpdate()
    {
        currentDuration -= Time.deltaTime;
    }
}