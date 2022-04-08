using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeMenuManager : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject panelPrefab;
    public GameObject[] locationList;


    public float tradeInterval = 10;
    private float tradeTimer;

    public float maxDuration;
    public float minDuration;

    public int priceChange; //Max fluctuation of the price

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
        GameObject panel = Instantiate(panelPrefab, parentObject.transform);

        //Get reference to a random location gameobject. Then pick an item from its itemlist and store it in an Item struct. Lastly randomize the price based on the retail and pricemargin(as an integer)
        int locationIndex = Random.Range(0, locationList.Length);
        GameObject location = locationList[locationIndex];

        Item[] itemList = location.GetComponent<Location>().itemList;

        int itemIndex = Random.Range(0, itemList.Length);
        Item item = itemList[itemIndex];


        string locationName = location.name;
        string itemName = item.name; 
        int price = item.price + Random.Range(-priceChange, priceChange); //uint and int mayhem

        float duration = Random.Range(minDuration, maxDuration);
        panel.GetComponent<TradePanel>().SetTrade(locationName, itemName, price, duration);
    }
}
