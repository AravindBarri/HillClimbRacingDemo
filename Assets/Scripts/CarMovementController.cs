using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementController : MonoBehaviour
{
    public Rigidbody2D BackTire, FrontTire, Car;
    public float speed, movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        
        BackTire.AddTorque(-movement* speed * Time.fixedDeltaTime);
        FrontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        Car.AddTorque(-movement * speed * Time.fixedDeltaTime);
    }
}
