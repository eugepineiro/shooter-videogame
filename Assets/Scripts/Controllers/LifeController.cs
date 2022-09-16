using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequiereComponent(typeof(Actor))]
public class LifeController : MonoBehaviour, IDamageable
{   

    [SerializeField] private ActorStats _actorStats;

    public float MaxLife => /*GetComponent<Actor>().ActorStats*/_actorStats.MaxLife;
    //[SerializeField] private float _maxLife = 100; 
    [SerializeField] private float _currentLife; 

    private void Start(){
        _currentLife = MaxLife;
    }
     
    public void TakeDamage(float damage)
    {
        _currentLife -= damage;
        if (_currentLife <= 0) Die();
    }

     
    public void Die() => Destroy(this.gameObject); //this es el componente, hay que usar this.gameobject para que borre todo el object
}
