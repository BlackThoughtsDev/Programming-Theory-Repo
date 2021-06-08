using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterClass : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;

    [SerializeField] private float m_Size = 1.5f;
    public float Size
    {
        get { return m_Size; }
        set
        {
            m_Size = value;
        }
    }

    [SerializeField] private float m_Speed = 5f;
    public float Speed
    {
        get { return m_Speed; }
        set { m_Speed = value; }
    }

    protected Transform newtransform;

    protected abstract void DoAThing();

    protected virtual void Walk()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * Speed * verticalInput);
    }

    protected void GetAxis()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    protected void NewTransform()
    {
        newtransform = GetComponent<Transform>();
    }

    protected void SizeMultiplier()
    {
        float xScale = newtransform.localScale.x;
        if(xScale < 1.5f)
        {
            newtransform.localScale *= m_Size;
        }
    }

}
