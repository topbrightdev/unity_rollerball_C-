using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 3; 

    void Start()
    {
        Debug.log("123"); 
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }

    void collidedWithEnemy(Enemy enemy)
    {
        if (health == 0) Application.Quit(); 

        enemy.Attack(this); 
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            collidedWithEnemy(enemy);
        }
    }

}
