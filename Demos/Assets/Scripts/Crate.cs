using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour, IDamage
{
   public void TakeDamage()
    {
        Destroy(gameObject);
    }
}
