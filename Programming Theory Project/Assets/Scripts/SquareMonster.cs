using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SquareMonster : MonsterClass
{
    private void Start()
    {
        NewTransform();
    }

    // ABSTRACTION
    void Update()
    {
        GetAxis();
        Walk();
        DoAThing();
    }

    // POLYMORPHISM
    protected override void DoAThing()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SizeMultiplier();
        }
    }
}
