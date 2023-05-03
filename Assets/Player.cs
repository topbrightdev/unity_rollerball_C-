using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private int count;
    private KeyCode[] inputKeys;
    private Vector3[] directionsForKeys; 
    //public GUIText countText; 
    void Start()
    {   
        inputKeys = new KeyCode[] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
        directionsForKeys = new Vector3[] { Vector3.forward, Vector3.left, Vector3.back, Vector3.right };
        //rigidBody = GetComponent<Rigidbody>();
        count = 0;
        //CountText(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        Rigidbody rb = GetComponent<Rigidbody>();   
        rb.AddForce(movement * speed * Time.deltaTime);  
    }
    void onTriggerEnter(Collider other)
    {
        Debug.Log("sdf"); 
        if (other.gameObject.tag == "item")
        {
            other.gameObject.SetActive(false); 
            count++;
            Debug.Log("The count is" + count); 
        }
    }
}
