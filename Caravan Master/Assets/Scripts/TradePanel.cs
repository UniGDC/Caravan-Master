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

    public void SetTrade(string _location, string _item, int _price, float _duration, string textTemplate) // Runs when the trade is initially created
    {
        location = _location;
        item = _item;
        price = _price.ToString();

        maxDuration = _duration;
        currentDuration = maxDuration;

        SetText(textTemplate);
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
        GameObject.Destroy(gameObject);
    }

    public void Accept()
    {
        GameObject.Destroy(gameObject);
    }

    public void Decline()
    {
        GameObject.Destroy(gameObject);
    }

    void SetText(string textTemplate)
    {
        //Select random text template        
        tradeText.text = textTemplate.Replace("[location]", location).Replace("[price]", price).Replace("[item]", item);
    }
}