using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{
    //getting the bullet assest to use for the shootingscript
    [SerializeField]
    public GameObject bullet;
    //used with the fire dealy to put a cooldown after exacuting the shooting fuction
    public float lastFiredTime = 0f;
    [SerializeField]
    public float fireDelay = 1f;
    //offseting the spwanpoint of the bullet so that it aligns with the front of the ship
    public float bulletOffset = 2f;

    void Start()
    {
        // Do some math to perfectly spawn bullets in front of us
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    // Update is called once per frame
    void Update()
    {
       
    }
  

}
