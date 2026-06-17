using System;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public int startlife = 10;
    public bool _destroyOnKill = false;  
    public Action OnKill;
    public float delayToDie = 0f;

    private int _currentLife;
    private bool _isDead = false;
    [SerializeField] private FlashColor _flashColor;


    void Awake()
    {
        Init();
        if(_flashColor == null)
        {
            _flashColor = GetComponent<FlashColor>();
        }
    }

    private void Init()
    {  
        _currentLife = startlife;
    }


    public void Damage(int damage)
    {
        if (_isDead)
        {
            return;
        }
        Debug.Log("Damage Taken: " + damage);
        
        _currentLife -= damage;

        if(_currentLife <= 0)
        {
            Die();
        }

        if(_flashColor != null)
        {
            _flashColor.Flash();
        }
    }   

    private void Die()
    {
        _isDead = true;
        if (_destroyOnKill)
        {
            Destroy(gameObject, delayToDie);
        }
        OnKill?.Invoke();
    }
}
