using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="CapsuleData", menuName = "Capsule Stats", order = 1)]

public class CapsuleStats : ScriptableObject
{
    public int strength = 0;
    public int body = 0;
    public int will = 0;
    public string catchPhrase = "NOT SET";
}
