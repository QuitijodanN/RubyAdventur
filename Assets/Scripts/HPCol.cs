using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RubyController1 controller = collision.GetComponent<RubyController1>();
        if (controller != null)
        {
            if (controller.hp < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }

        }
    }
}
