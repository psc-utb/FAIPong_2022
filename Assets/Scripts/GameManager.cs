using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }
    }
    private GameManager()
    {
        gameManagerData = GameManagerData.Instance;
    }
    */


    [SerializeField]
    GameManagerData gameManagerData;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerData.IsPaused == false && Input.GetKey(gameManagerData.MenuKey))
        {
            Time.timeScale = 0;
            gameManagerData.IsPaused = true;
            gameManagerData.MenuCanvas.SetActive(true);
        }
    }

    public void ZvysScoreHrace1(int points)
    {
        gameManagerData.Player1Score += points;
        if (gameManagerData.Player1Text != null)
        {
            gameManagerData.Player1Text.text =
                gameManagerData.Player1String + gameManagerData.Player1Score;
        }
    }


    public void ZvysScoreHrace2(int points)
    {
        gameManagerData.Player2Score += points;
        if (gameManagerData.Player2Text != null)
        {
            gameManagerData.Player2Text.text =
                gameManagerData.Player2String + gameManagerData.Player2Score;
        }
    }

    public void StartButton()
    {
        Time.timeScale = 1.0f;
        gameManagerData.IsPaused = false;
        gameManagerData.MenuCanvas.SetActive(false);
    }

    public void ExitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
