using System.Collections;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    public ProjectileBase projectilePrefab;
    public Transform firePoint;
    public float shootInterval = 0.5f;

    public Transform playerSideReference;

    private Coroutine _currentCoroutine;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentCoroutine = StartCoroutine(ShootCoroutine());
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (_currentCoroutine != null)
            {
                StopCoroutine(_currentCoroutine);
            }
        }
    }

    IEnumerator ShootCoroutine()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(shootInterval);
        }
    }

    public void Shoot()
    {
        var projectile = Instantiate(projectilePrefab);
        projectile.transform.position = firePoint.position;
        projectile.side = playerSideReference.transform.localScale.x;
    }
}