using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TradePanel : MonoBehaviour
{
    public Text tradeText;
    public Slider duration;

    private string location;
    private string item;
    private string price;

    private float maxDuration;
    private float currentDuration;

    void SetTrade(string _location, string _item, int _price, float _duration) // Runs when the trade is initially created
    {
        location = _location;
        item = _item;
        price = _price.ToString();

        maxDuration = _duration;
        currentDuration = maxDuration;

        SetText();
    }

    void Update()
    {
        currentDuration -= Time.deltaTime;

        duration.value = (currentDuration / maxDuration);

        if (currentDuration <= 0)
        {
            Expire();
        }
    }

    void Expire()
    {
        //Debug.Log("expired");
    }

    public void Accept()
    {
        Debug.Log("accepted");
    }

    public void Decline()
    {

    }

    void SetText()
    {
        //Select random text template
        tradeText.text = location + " dispatches a trade of " + price + " for these " + item + "s. Is this trade satisfactory?";
    }
}