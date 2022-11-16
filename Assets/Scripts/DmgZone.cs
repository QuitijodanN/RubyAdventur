using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController1 controller = other.GetComponent<RubyController1>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
