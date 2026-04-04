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
        //calling these 2 fuctions after setting up our direction vector, one for starting velocity and the other for overall movement speed
        objectmovescript.move(Direction);
        objectmovescript.StartSpeed(Direction);
    }
}
