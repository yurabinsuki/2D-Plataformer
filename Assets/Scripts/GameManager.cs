using UnityEngine;
using Ebac.Core.Singleton;
using System.Collections.Generic;
using DG.Tweening;

public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    public GameObject playerPrefab;


    [Header("Enemies")]
    public List<GameObject> enemies;


    [Header("References")]
    public Transform startPoint;

    [Header("Animation")]   
    public float duration = 0.5f;
    public float delay = 0.15f;
    public Ease ease = Ease.OutBack;

#region private variables
    private GameObject _currentPlayer;

#endregion

    void Start()
    {
        Init();
    }

    public void Init()
    {
        SpawnPlayer();
    } 


    private void SpawnPlayer()
    {
        _currentPlayer = Instantiate(playerPrefab);
        _currentPlayer.transform.position = startPoint.transform.position;
        _currentPlayer.transform.DOScale(0, duration).SetEase(ease).From().SetDelay(delay);
    }

}
