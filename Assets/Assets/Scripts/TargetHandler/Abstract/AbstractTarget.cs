using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractTarget : MonoBehaviour
{

    public abstract void GetDamage(float damage);

    public abstract void Smite();

}
