using UnityEngine;
using Ebac.Core.Singleton;
using TMPro;

public class ItemManager : Singleton<ItemManager>
{
    public TextMeshProUGUI coinsCounterText;
    public int coins = 0;


    void Start()
        {
            Reset();
        }

    private void Reset()
    {
        coins = 0;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        coinsCounterText.text = "x " + coins.ToString();
    }
}
