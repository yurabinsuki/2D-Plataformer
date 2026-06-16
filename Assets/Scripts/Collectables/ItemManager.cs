using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    public int coins = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
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
