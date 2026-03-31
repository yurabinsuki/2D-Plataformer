using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name); 

        var helth = collision.transform.GetComponent<HealthBase>();

        if(helth != null)
        {
            helth.Damage(damage);
        }
    }
}
