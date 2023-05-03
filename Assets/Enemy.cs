using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
    public int health;
    public int damage;
    public Transform targetTransform; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {

        if (targetTransform != null) { 
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetTransform.transform.position, Time.deltaTime * movespeed);
        }
    }

    public void TaskDamage(int damage)
    {
        health -= damage; 
        if (health <= 0) { 
            Destroy(this.gameObject);
        }
    }
    public void Attack(player1 player)
    {
        player.health -= this.health;
        Destroy(this.gameObject);
    }
    public void Initialize(Transform target, float moveSpeed, int health)
    {
        this.targetTransform = target;
        this.movespeed = moveSpeed;
        this.health = health;
    }
}
