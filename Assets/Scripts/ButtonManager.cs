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

    public void ClosePanel()
    {
        panel.SetActive(false);
    }

    public void DepositWithBtn(int number)
    {
        GameManager.instance.currCash = int.Parse(cash.text);
        GameManager.instance.currBalance = int.Parse(balance.text);
        if (GameManager.instance.currCash - number >= 0)
        {
            GameManager.instance.currBalance += number;
            GameManager.instance.currCash -= number;
            balance.text = GameManager.instance.currBalance.ToString();
            cash.text = GameManager.instance.currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void DepositWithUsrTxt()
    {
        GameManager.instance.currCash = int.Parse(cash.text);
        GameManager.instance.currBalance = int.Parse(balance.text);
        if (GameManager.instance.currCash - int.Parse(inputText.text) >= 0)
        {
            GameManager.instance.currBalance += int.Parse(inputText.text);
            GameManager.instance.currCash -= int.Parse(inputText.text);
            balance.text = GameManager.instance.currBalance.ToString();
            cash.text = GameManager.instance.currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        inputText.text = "";
    }

    public void WithdrawWithBtn(int number)
    {
        GameManager.instance.currCash = int.Parse(cash.text);
        GameManager.instance.currBalance = int.Parse(balance.text);
        if (GameManager.instance.currBalance - number >= 0)
        {
            GameManager.instance.currCash += number;
            GameManager.instance.currBalance -= number;
            balance.text = GameManager.instance.currBalance.ToString();
            cash.text = GameManager.instance.currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
    }

    public void WithdrawWithUsrTxt()
    {
        GameManager.instance.currCash = int.Parse(cash.text);
        GameManager.instance.currBalance = int.Parse(balance.text);
        if (GameManager.instance.currBalance - int.Parse(inputText.text) >= 0)
        {
            GameManager.instance.currCash += int.Parse(inputText.text);
            GameManager.instance.currBalance -= int.Parse(inputText.text);
            balance.text = GameManager.instance.currBalance.ToString();
            cash.text = GameManager.instance.currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        inputText.text = "";
    }
}
