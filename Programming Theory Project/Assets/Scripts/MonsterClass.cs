using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterClass : MonoBehaviour
{
    [SerializeField] float speed = 5;
    private float horizontalInput;
    private float verticalInput;
    protected Transform newtransform;

    protected abstract void DoAThing();
    
    protected void Walk()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
    }

    protected void GetAxis()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }

    protected void NewTransform()
    {
        newtransform = GetComponent<Transform>();
    }
}
