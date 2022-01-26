using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text balanceText;
    public Image playerSprite;
    
    public void SetBalanceText(string balance)
    {
        balanceText.text = balance;
    }

    public void SetPlayerSprite(Sprite sprite)
    {
        playerSprite.sprite = sprite;
    }
}
