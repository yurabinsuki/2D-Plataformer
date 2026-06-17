using UnityEngine;

public class PlayerDeathHelper : MonoBehaviour
{
    public Player player;

    public void KillPlayer()
    {
        player.DestroyMe();
    }
}
