using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int damage;
    Vector3 shootDirection; 
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        this.transform.Translate(shootDirection * speed , Space.World);
    }
    public void FireProjectile(Ray shootRay)
    {
        this.shootDirection = shootRay.direction;
        this.transform.position = shootRay.origin; 
    }

    void OnCollisionEnter (Collision collision)
    {
        Enemy enemy = collision.collider.gameObject.GetComponent<Enemy>();
        if (enemy) {
            enemy.TaskDamage(damage); 
        }
        Destroy(this.gameObject);
    }
}
