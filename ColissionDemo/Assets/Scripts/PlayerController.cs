using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //Speed scale, editible property in inspector.
    public float speed;

    private Rigidbody playerBody;

    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
    
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        playerBody.AddForce(movement*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }

}