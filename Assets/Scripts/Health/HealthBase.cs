using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public int startlife = 10;
    public bool _destroyOnKill = false;  

    private int _currentLife;
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
        if (_destroyOnKill)
        {
            Destroy(gameObject);
        }
    }
}
