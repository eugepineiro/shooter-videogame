using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBullet
{
    float Speed { get; }

    float LifeTime { get; }
    
    void Travel();
}