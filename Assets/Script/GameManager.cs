using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    //Buat UI Text
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR; 
    public TMP_Text textWin;


    public static GameManager instance;
    public GameObject winCon;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }


    //Method penyeleksi untuk menambah score
    public void AddScore(string wallName)
    {
        if (wallName == "LineL")
        {
            PlayerScoreR = PlayerScoreR + 10; //Menambah score
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //Mengisikan nilai integer PlayerScore ke UI
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }
    public void ScoreCheck()
    {
        if (PlayerScoreR == 30)
        {
            WinCondition("Player 2 Win!");
        }
        else if (PlayerScoreL == 30)
        {
            WinCondition("Player 1 Win!");
        }
    }
    private void WinCondition(string text)
    {
        winCon.SetActive(true);
        textWin.text = text;
        Time.timeScale = 0;
    }
}