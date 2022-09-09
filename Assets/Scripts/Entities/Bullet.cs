using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IBullet
{
   
    [SerializeField] private float _speed = 10;
    [SerializeField] private float _lifetime = 5;
    
    public float Speed => _speed;
    public float LifeTime => _lifetime;

    public int Damage => _damage;
    [SerializeField] private int _damage = 10;

    public Collider Collider => _collider;
    [SerializeField] private Collider _collider;

    public Rigidbody Rigidbody => _rigidbody;
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private List<int> _layerTarget;

    public void Travel() => transform.position += transform.forward * Time.deltaTime * Speed;
    
    
    private void OnTriggerEnter(Collider collider) {
        
        if(_layerTarget.Contains(collider.gameObject.layer)) {
            IDamageable damageable = collider.GetComponent<IDamageable>();
            damageable?.TakeDamage(_damage);
            Destroy(this.gameObject);
        }
        
    }

    void Start() { 
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<Collider>();

        _collider.isTrigger = true; 
        _rigidbody.useGravity = false; 
        _rigidbody.isKinematic = true; // no queremos que rebote 
        _rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
    }

    void Update()
    {
        
        _lifetime -= Time.deltaTime;
        if (_lifetime <= 0) Destroy(this.gameObject);

        Travel();
    }
 


}