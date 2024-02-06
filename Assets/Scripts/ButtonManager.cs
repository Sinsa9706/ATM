using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text cash;
    public Text balance;
    public Text inputText;
    public GameObject panel;

    public void DepositButton()
    {
        SceneManager.LoadScene("DepositScene");
    }

    public void WithdrawButton()
    {
        SceneManager.LoadScene("WithdrawScene");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoginButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }

    public void DepositWithBtn(int number)
    {
        bool check = GameManager.instance.Deposit(number);
        if (check)
        {
            balance.text = string.Format("{0: #,###;;0}", GameManager.instance.currBalance);
            cash.text = string.Format("{0: #,###;;0}", GameManager.instance.currCash);
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void DepositWithUsrTxt()
    {
        int number = int.Parse(inputText.text);
        bool check = GameManager.instance.Deposit(number);
        if (check)
        {
            balance.text = string.Format("{0: #,###;;0}", GameManager.instance.currBalance);
            cash.text = string.Format("{0: #,###;;0}", GameManager.instance.currCash);
        }
        else
        {
            panel.SetActive(true);
        }
        inputText.text = "";
    }

    public void WithdrawWithBtn(int number)
    {
        bool check = GameManager.instance.Withdraw(number);
        if (check)
        {
            balance.text = string.Format("{0: #,###;;0}", GameManager.instance.currBalance);
            cash.text = string.Format("{0: #,###;;0}", GameManager.instance.currCash);
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void WithdrawWithUsrTxt()
    {
        int number = int.Parse(inputText.text);
        bool check = GameManager.instance.Withdraw(number);
        if (check)
        {
            balance.text = string.Format("{0: #,###;;0}", GameManager.instance.currBalance);
            cash.text = string.Format("{0: #,###;;0}", GameManager.instance.currCash);
        }
        else
        {
            panel.SetActive(true);
        }
        inputText.text = "";
    }
}
