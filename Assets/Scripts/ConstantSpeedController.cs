using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{

    [SerializeField]
    private Vector2 Direction;
    [SerializeField]
    private ObjectMoveScript objectmovescript;

    // Start is called before the first frame update
    void Start()
    {
     
    }
    

    // Update is called once per frame
    void Update()
    {
        objectmovescript.move(Direction);
        objectmovescript.StartSpeed(Direction);
    }
}
