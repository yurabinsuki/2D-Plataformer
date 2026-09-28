using UnityEngine;

public class CollectableCoin : CollectableBase
{

    public Collider2D collider;
   override protected void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins(1);
        collider.enabled = false;
    }
}
