using UnityEngine;

public class CollectableRedCoin : CollectableBase
{
    override protected void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins(5);
    }
}
