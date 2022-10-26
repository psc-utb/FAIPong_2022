using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class GameManagerData
{
    //singleton -> nikde jinde nechceme dalsi instanci, protoze jinak bychom meli vic dat pro jednu a tu samou vec (napr. skore hrace 1 by bylo ruzne v ruznych instancich)
    private static GameManagerData instance;
    public static GameManagerData Instance
    {
        get
        {
            if (instance == null)
                instance = new GameManagerData();
            return instance;
        }
    }
    private GameManagerData()
    {
    }

    [Tooltip("Prvek UI.Text v uzivatelskem rozhrani, kam se bude vypisovat skore hrace 1")]
    [SerializeField]
    TextMeshProUGUI player1Text;
    public TextMeshProUGUI Player1Text
    {
        get { return player1Text; }
        set { player1Text = value; }
    }

    [Tooltip("Retezec, ktery se vypise do prvku UI.Text v uzivatelskem rozhrani pred hodnotou skore hrace 1")]
    [SerializeField]
    string player1String;
    public string Player1String
    {
        get { return player1String; }
        set { player1String = value; }
    }

    [Tooltip("Skore hrace 1, ktere se vypise za retezec do UI.Text v uzivatelskem rozhrani")]
    [SerializeField]
    int player1Score;
    public int Player1Score
    {
        get { return player1Score; }
        set { player1Score = value; }
    }


    [Tooltip("Prvek UI.Text v uzivatelskem rozhrani, kam se bude vypisovat skore hrace 2")]
    [SerializeField]
    TextMeshProUGUI player2Text;
    public TextMeshProUGUI Player2Text
    {
        get { return player2Text; }
        set { player2Text = value; }
    }

    [Tooltip("Text, ktery se vypise do prvku UI.Text v uzivatelskem rozhrani pred hodnotou skore hrace 2")]
    [SerializeField]
    string player2String;
    public string Player2String
    {
        get { return player2String; }
        set { player2String = value; }
    }

    [Tooltip("Skore hrace 2, ktere se vypise za retezec do UI.Text v uzivatelskem rozhrani")]
    [SerializeField]
    int player2Score;
    public int Player2Score
    {
        get { return player2Score; }
        set { player2Score = value; }
    }

    [Tooltip("Nastaveni, zda je hra pauzovana")]
    [SerializeField]
    bool isPaused = true;
    public bool IsPaused
    {
        get { return isPaused; }
        set { isPaused = value; }
    }

    [Tooltip("Klavesa pro otevreni a zavreni menu")]
    [SerializeField]
    KeyCode menuKey;
    public KeyCode MenuKey
    {
        get { return menuKey; }
        set { menuKey = value; }
    }

    [Tooltip("Odkaz na Canvas s prvky menu")]
    [SerializeField]
    GameObject menuCanvas;
    public GameObject MenuCanvas
    {
        get { return menuCanvas; }
        set { menuCanvas = value; }
    }

}