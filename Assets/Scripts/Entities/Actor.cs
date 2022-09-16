using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Actor : MonoBehaviour
{
    public ActorStats ActorStats => _actorStats;
    [SerializeField] public ActorStats _actorStats;
    
  
}
