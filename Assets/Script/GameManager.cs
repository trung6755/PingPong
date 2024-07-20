using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle player;
    public Paddle opp;    
    private int _playerScore;
    private int _oppScore;

    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text oppScoreText;

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
}
