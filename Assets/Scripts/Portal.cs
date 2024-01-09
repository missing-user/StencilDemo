using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public GameObject world;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        int StencilLayer1 = LayerMask.NameToLayer("StencilLayer1");
        int StencilLayer2 = LayerMask.NameToLayer("StencilLayer2");
        int Default = LayerMask.NameToLayer("Default");

        Debug.Log("Triggered");
        
        world.layer = Default;   
        var children = world.GetComponentsInChildren<Transform>(includeInactive: true);
        foreach (var child in children)
        {
//            Debug.Log(child.name);
            child.gameObject.layer = Default;
        } 
    }
}
