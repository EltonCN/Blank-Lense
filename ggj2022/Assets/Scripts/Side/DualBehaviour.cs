using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualBehaviour : DualThing
{
    [SerializeField]List<GameObject> sideA_Objects;
    [SerializeField]List<MonoBehaviour> sideA_Scripts;

    [SerializeField]List<GameObject> sideB_Objects;
    [SerializeField]List<MonoBehaviour> sideB_Scripts;

    protected override void  OnSideA()
    {
        foreach(GameObject obj in sideA_Objects)
        {
            obj.SetActive(true);
        }
        foreach(GameObject obj in sideB_Objects)
        {
            obj.SetActive(false);
        }

        foreach(MonoBehaviour script in sideA_Scripts)
        {
            script.enabled = true;
        }
        foreach(MonoBehaviour script in sideB_Scripts)
        {
            script.enabled = false;
        }

    }

    protected override void OnSideB()
    {
        foreach(GameObject obj in sideB_Objects)
        {
            obj.SetActive(true);
        }
        foreach(GameObject obj in sideA_Objects)
        {
            obj.SetActive(false);
        }

        foreach(MonoBehaviour script in sideB_Scripts)
        {
            script.enabled = true;
        }
        foreach(MonoBehaviour script in sideA_Scripts)
        {
            script.enabled = false;
        }
    }

}
