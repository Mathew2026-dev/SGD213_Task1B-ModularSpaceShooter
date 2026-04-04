using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private ShootingScript Shootscript;

    // Start is called before the first frame update
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float CurrentTime = Time.time;
            // Have a delay so we don't shoot too many bullets
            // grabing the variables from the "ShootingScript" and using the information from it to set the fuctions
            if (CurrentTime - Shootscript.lastFiredTime > Shootscript.fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + Shootscript.bulletOffset);

                Instantiate(Shootscript.bullet, spawnPosition, transform.rotation);

                Shootscript.lastFiredTime = CurrentTime;
                //print("Shoot!");
                print("Shoot");
            }
        }
    }
}
