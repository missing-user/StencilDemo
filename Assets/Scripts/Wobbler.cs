using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobbler : MonoBehaviour
{
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos + Vector3.up * Mathf.Sin(Time.time);
    }
}
