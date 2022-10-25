using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance != null) //<><>
                instance = new GameManager();
            return instance;
        }
    }
    private GameManager()
    {
    }


    [SerializeField]
    GameManagerData gameManagerData;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ZvysScoreHrace1()
    {
        gameManagerData.Player1Score += 1;
    }


    public void ZvysScoreHrace2()
    {
        gameManagerData.Player2Score += 1;
    }
}
