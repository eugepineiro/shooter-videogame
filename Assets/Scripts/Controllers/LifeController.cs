using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour, IDamageable
{   
    public float MaxLife => _maxLife;
    [SerializeField] private float _maxLife = 100; 
    [SerializeField] private float _currentLife; 

    private void Start(){
        _currentLife = _maxLife;
    }
     
    public void TakeDamage(float damage)
    {
        _currentLife -= damage;
        if (_currentLife <= 0) Die();
    }

     
    public void Die() => Destroy(this.gameObject); //this es el componente, hay que usar this.gameobject para que borre todo el object
}
