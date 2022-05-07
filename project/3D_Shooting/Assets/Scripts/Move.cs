using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("左へ移動");
            rigidBody.AddForce(Vector3.left * moveSpeed);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("右へ移動");
            rigidBody.AddForce(Vector3.right * moveSpeed);
        }
    }
}
