using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMonster : MonsterClass
{
    private void Start()
    {
        size = 1.2f;
        speed = 6;
        NewTransform();
    }

    void Update()
    {
        GetAxis();
        Walk();
        DoAThing();
    }

    protected override void DoAThing()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SizeMultiplier();
        }
    }
}
