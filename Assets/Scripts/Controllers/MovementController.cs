using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequiereComponent(typeof(Actor))]
public class MovementController : MonoBehaviour, IMoveable
{
    [SerializeField] private ActorStats _actorStats;
   
    public float Speed => /*GetComponent<Actor>().ActorStats*/ _actorStats.MovementSpeed; // el getter devuelve el valor guardado en el stat
    //[SerializeField] private float _speed = 5;

    public float RotationSpeed => /*GetComponent<Actor>().ActorStats*/_actorStats.RotationSpeed;
    //[SerializeField] private float _rotationSpeed = 10;
    
    public void Travel(Vector3 direction) => transform.Translate(direction * Time.deltaTime * Speed); // lo llama el cmdMovement

    public void Rotate(Vector3 direction) => transform.Rotate(direction * Time.deltaTime * RotationSpeed);
    
    
}