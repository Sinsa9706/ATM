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

    public int currCash;
    public int currBalance;

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

    public void ClosePanel()
    {
        panel.SetActive(false);
    }

    public void DepositWithBtn(int number)
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currCash - number >= 0)
        {
            currBalance += number;
            currCash -= number;
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void DepositWithUsrTxt()
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currCash - int.Parse(inputText.text) >= 0)
        {
            currBalance += int.Parse(inputText.text);
            currCash -= int.Parse(inputText.text);
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        inputText.text = "";
    }

    public void WithdrawWithBtn(int number)
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currBalance - number >= 0)
        {
            currCash += number;
            currBalance -= number;
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void WithdrawWithUsrTxt()
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currBalance - int.Parse(inputText.text) >= 0)
        {
            currCash += int.Parse(inputText.text);
            currBalance -= int.Parse(inputText.text);
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        inputText.text = "";
    }
}
