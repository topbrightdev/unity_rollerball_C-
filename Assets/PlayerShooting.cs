using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public projectile projectilePrefab;
    public LayerMask mask; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void shoot (RaycastHit hit)
    {
        var projectile = Instantiate(projectilePrefab).GetComponent <projectile>();
        var pointAboveFloor = hit.point + new Vector3(0 ,this.transform.position.y, 0);
        var direction = pointAboveFloor - transform.position;
        var shootRay = new Ray(this.transform.position, direction);
        Physics.IgnoreCollision(GetComponent<Collider>(), projectile.GetComponent<Collider>());
        projectile.FireProjectile(shootRay);
    }
}
