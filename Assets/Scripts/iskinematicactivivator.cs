using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iskinematicactivivator : MonoBehaviour
{
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= 1)
        {
            rigid.isKinematic = true;
        }
    }
}
