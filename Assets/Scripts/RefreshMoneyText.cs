using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefreshMoneyText : MonoBehaviour
{
    public Text cash;
    public Text balance;

    private void Start()
    {
        RefreshMoney();
    }

    public void RefreshMoney()
    {
        cash.text = GameManager.instance.currCash.ToString();
        balance.text = GameManager.instance.currBalance.ToString();
    }
}
