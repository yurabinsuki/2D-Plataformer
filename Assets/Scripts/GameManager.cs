using UnityEngine;
using Ebac.Core.Singleton;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    public GameObject playerPrefab;

    [Header("References")]
    public Transform startPoint;
    public GameObject endGameUI;


    [Header("Animation")]   
    public float duration = 0.5f;
    public float delay = 0.15f;
    public Ease ease = Ease.OutBack;

    [SerializeField] private GameObject _currentPlayer;

    void Start()
    {
        endGameUI.SetActive(false);
        Init();
    }

    public void Init()
    {
        if (_currentPlayer == null)
        {
            SpawnPlayer();
        }
    } 


    private void SpawnPlayer()
    {
        _currentPlayer = Instantiate(playerPrefab);
        _currentPlayer.transform.position = startPoint.transform.position;
        _currentPlayer.transform.DOScale(0, duration).SetEase(ease).From().SetDelay(delay);
    }
    public void EndGame()
        {
            endGameUI.SetActive(true);
            Time.timeScale = 0;
        }


}
