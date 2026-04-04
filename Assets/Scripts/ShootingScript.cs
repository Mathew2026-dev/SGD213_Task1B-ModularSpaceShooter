using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{

    [SerializeField]
    public GameObject bullet;

    public float lastFiredTime = 0f;
    [SerializeField]
    public float fireDelay = 1f;

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
