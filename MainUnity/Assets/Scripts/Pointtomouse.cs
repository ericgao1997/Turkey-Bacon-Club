using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointtomouse : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float offset = 0.0f;
    public float rotation_z;
    // Use this for initialization
    void Start()
    {

    }
    void Follow_Mouse()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z - 90);
    }
    void Fire_bullet()
    {

        var bullet = (GameObject)Instantiate(bulletPrefab, transform.position, new Quaternion(0, 0, 0, 0));
        bullet.transform.rotation = Quaternion.Euler(0, 0, rotation_z - 180);



        // Add velocity to the bullet


        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2.0f);
    }
    // Update is called once per frame
    void Update()
    {
        Follow_Mouse();
        if (Input.GetMouseButtonDown(0))
        {   //leftmouse click
            Fire_bullet();
        }
    }
}
