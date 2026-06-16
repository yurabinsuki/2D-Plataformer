using UnityEngine;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{
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
        Debug.Log("Coins: " + coins);
    }
}
