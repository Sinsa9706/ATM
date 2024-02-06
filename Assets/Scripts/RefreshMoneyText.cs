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
        cash.text = string.Format("{0: #,###;;0}", GameManager.instance.currCash);
        balance.text = string.Format("{0: #,###;;0}", GameManager.instance.currBalance);
    }
}