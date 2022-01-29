using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnFire : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
