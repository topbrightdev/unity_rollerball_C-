using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;

public class camera_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;
    private Transform transform1;
    public float movespeed; 
    void Start()
    {
        transform1 = this.transform.parent;  
        offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate ()
    {
        if (player == null) Application.Quit();
        transform.position = player.transform.position + offset;
    }
    void FixedUpdate()
    {
        if (player == null)
        {
            return;
        }
        transform1.position = Vector3.Lerp(transform1.position, player.transform.position, Time.deltaTime * movespeed);
    }
}
