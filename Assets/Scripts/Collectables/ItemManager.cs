using UnityEngine;
using Ebac.Core.Singleton;
using TMPro;

public class ItemManager : Singleton<ItemManager>
{
    public TextMeshProUGUI coinsCounterText;
    public SOInt coins;

    void Start()
        {
            Reset();
        }

    private void Reset()
    {
        coins.value = 0;
    }

    public void AddCoins(int amount)
    {
        coins.value += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        UiInGameManager.Instance.UpdateTextCoins("x " + coins.ToString());
    }
}
