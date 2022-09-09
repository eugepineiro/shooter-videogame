using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour, IMoveable
{
    
    public float Speed => _speed;
    [SerializeField] private float _speed = 5;

    public float rotationSpeed => _rotationSpeed;
    [SerializeField] private float _rotationSpeed = 10;
   

   
    public void Travel(Vector3 direction) => transform.Translate(direction * Time.deltaTime * _speed); // lo llama el cmdMovement

    public void Rotate(Vector3 direction) => transform.Rotate(direction * Time.deltaTime * _rotationSpeed);
    
    
}