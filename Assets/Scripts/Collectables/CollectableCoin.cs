using UnityEngine;

public class CollectableCoin : CollectableBase
{
   override protected void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins(1);
    }
}
