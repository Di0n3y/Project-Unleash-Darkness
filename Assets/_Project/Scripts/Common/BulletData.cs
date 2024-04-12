using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletData : MonoBehaviour
{

    [SerializeField] private int _damage = 1;
    [SerializeField] private float _lifetime = 5f;
    public int Damage => _damage;

    private void Start()
    {
        Destroy(gameObject, _lifetime);
    }
}
