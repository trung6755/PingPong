using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Ball ball;
    public Paddle player;
    public Paddle opp;    
    private int _playerScore;
    private int _oppScore;

    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text oppScoreText;

    public GameState GameState { get;private set; }
    public event Action<GameState> GameStateChanged;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        EventManager.OnTimerStart();
    }
    public void PlayerScore()
    {
        _playerScore++;

        this.playerScoreText.text = _playerScore.ToString();
        ResetPos();
        
    }

    public void OppScore()
    {
        _oppScore++;
        this.oppScoreText.text = _oppScore.ToString();
        ResetPos();
        
    }

    private void ResetPos()
    {
        this.ball.ResetPos();
        this.ball.AddStartingForce();
        this.player.ResetPosition();
        this.opp.ResetPosition();
    }

    public void SetGameOver(GameState gameState)
    {
        this.GameState = gameState;
        if (gameState == GameState.GameOver)
        {
            this.GameStateChanged?.Invoke(this.GameState);
        }
    }
}

public enum GameState
{
    Playing = 0,
    GameOver = 1
}