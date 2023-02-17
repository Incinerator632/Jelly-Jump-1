using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab; // The projectile to be fired
    public Transform firePoint; // The point from which the projectile will be fired
    public float bulletForce = 20f; // The speed of the projectile

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { // Check if the player presses the fire button (left mouse button)
            Shoot(); // Call the Shoot function
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Create a new projectile
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component of the projectile
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse); // Add force to the projectile to make it move in the direction of the firePoint
    }
}
