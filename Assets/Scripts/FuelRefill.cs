using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelRefill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CarMovementController.carinstance.fuel = 1;
        Destroy(this.gameObject);
    }
}
