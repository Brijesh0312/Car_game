using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class charactercontroller : MonoBehaviour
{
    CharacterController Mover;
    // Start is called before the first frame update
    void Start()
    {
        Mover = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 coordinates = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Mover.Move(coordinates);
       transform.Rotate(0,0,Input.GetAxis("Horizontal"));
    }
}
