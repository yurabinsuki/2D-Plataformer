using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public int startlife = 10;
    public bool _destroyOnKill = false;   

    private int _currentLife;
    private bool _isDead;


    void Awake()
    {
        Init();
    }

    private void Init()
    {
        _isDead = false;    
        _currentLife = startlife;
    }


    public void Damage(int damage)
    {

        Debug.Log("Damage Taken: " + damage);
        
        _currentLife -= damage;

        if(_currentLife <= 0)
        {
            Die();
        }
    }   

    private void Die()
    {
        _isDead = true;

        if (_destroyOnKill)
        {
            Destroy(gameObject);
        }
    }
}
