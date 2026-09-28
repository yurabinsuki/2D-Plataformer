using UnityEngine;

public class CollectableRedCoin : CollectableBase
{
    public Collider2D collider;
    override protected void OnCollect()
    {
        base.OnCollect();
        ItemManager.Instance.AddCoins(5);
        collider.enabled = false;
    }
}
