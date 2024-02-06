using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int currCash;
    public int currBalance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
                Destroy(this.gameObject);
        }
    }

    public bool Deposit(int value)
    {
        if(currCash - value >= 0)
        {
            currCash -= value;
            currBalance += value;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Withdraw(int value)
    {
        if (currBalance - value >= 0)
        {
            currCash += value;
            currBalance -= value;
            return true;
        }
        else
        {
            return false;
        }
    }
}
