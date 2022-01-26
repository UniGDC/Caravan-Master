using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Variables")]
    public int balance;
    public Item[] currentItemList;

    [Header("UI Elements")]
    public PlayerUI playerUI;
    public PriceMenuUI priceMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DecreseBalance", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.SetBalanceText("$" + balance);
    }

    public void SetItemList(Item[] itemlist)
    {
        if(currentItemList != itemlist)
        {
            currentItemList = itemlist;
            priceMenuUI.GenerateCells(currentItemList);
        }
    }

    void DecreseBalance()
    {
        if(balance > 0) balance--;
    }
}
