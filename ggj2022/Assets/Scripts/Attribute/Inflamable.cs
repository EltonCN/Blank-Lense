using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(AttributeBag))]
public class Inflamable : MonoBehaviour
{
    [SerializeField] bool propagates = true;
    [SerializeField] float propagateRange = 1.0f;
    [SerializeField] bool destroys = false;
    [SerializeField] float timeToDestroy = 0.0f;
    [SerializeField] bool resetDestroyCountWithoutFire = false;
    [SerializeField] Attribute fireAttribute;

    AttributeBag bag;
    float timer;
    float lastTime = -1;

    void Start()
    {
        bag = GetComponent<AttributeBag>();
        timer = 0.0f;
    }

    void Update()
    {
        if(bag.HaveAttribute(fireAttribute))
        {
            if(lastTime == -1)
            {
                lastTime = Time.time;
            }

            timer += Time.time - lastTime;

            lastTime = Time.time;

            propagate();
        }
        else
        {
            lastTime = -1;

            if(resetDestroyCountWithoutFire)
            {
                timer = 0;
            }
        }
        

        if(timer > timeToDestroy && destroys)
        {
            Destroy(this.gameObject);
        }
    }

    void propagate()
    {
        if(!propagates)
        {
            return;
        }

        LayerMask mask = LayerMask.GetMask(LayerMask.LayerToName(gameObject.layer));

        Collider[] colliders = Physics.OverlapSphere(this.transform.position, propagateRange, mask);

        foreach(Collider col in colliders)
        {
            AttributeBag bag = col.GetComponent<AttributeBag>();

            if(bag != null)
            {
                bag.AddAttribute(fireAttribute);
            }
        }
    }
}