using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab = default;
    [SerializeField] private float _cooldown = 0.5f;
    [SerializeField] private Transform _spawnPoint = default;
    private float _currentCooldown = default;


    public void Shoot () 
    {

        if (_currentCooldown <= Time.timeSinceLevelLoad) 
        {
            Instantiate(_bulletPrefab, _spawnPoint.position,_spawnPoint.rotation);
            _currentCooldown = Time.timeSinceLevelLoad + _cooldown;
        }




    }

}
