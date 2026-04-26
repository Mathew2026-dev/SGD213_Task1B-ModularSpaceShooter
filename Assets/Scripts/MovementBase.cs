using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovementBase : MonoBehaviour
{

    [Header("Controls")]
    [SerializeField]
    protected float Acceleration = 5000f;
    protected Rigidbody2D ourRigidbody;
    protected Vector2 forceToAdd;
    
    protected Vector2 direction;

   
    
}
