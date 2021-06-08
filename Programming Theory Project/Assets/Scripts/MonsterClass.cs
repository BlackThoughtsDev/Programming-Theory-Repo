using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterClass : MonoBehaviour
{
    // ENCAPSULATION
    private float horizontalInput;
    private float verticalInput;

    private float m_Size = 1.1f;
    public float Size
    {
        get { return m_Size; }
        set
        {
            m_Size = value;
            if (newtransform.localScale.x > 1.5) m_Size = 0.9f;
            else if (newtransform.localScale.x < 0.5) m_Size = 1.1f;
        }
    }

    [SerializeField] private float m_Speed = 5f;
    public float Speed
    {
        get { return m_Speed; }
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
        newtransform.localScale *= m_Size;
        Size = m_Size;
    }

}
