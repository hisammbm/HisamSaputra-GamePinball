using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //hinge joint disimpan saat start terlebih dulu
    private HingeJoint hinge;
    private float targetPressed;
    private float targetRelease;
    //untuk menggatikan hardcore jointspring.spring = 1000;
    public KeyCode input;
    // Start is called before the first frame update
    void Start()
    {
        //hinge joint disimpan saat start terlebih dulu
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
        MovePaddle();
    }

    private void ReadInput()
    {
        //Read Input here
        //langsung menggunakan variabel yang sudah dibuat saat start
        JointSpring jointSpring = hinge.spring;

        //mengubah value spring saat input ditekan dan dilepas
        if(Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }else
        {
            jointSpring.targetPosition = targetRelease;
        }

        //disini pun langsung menggunakan variabel
        hinge.spring = jointSpring;
    }

    private void MovePaddle()
    {
        // Move paddle here
    }

    
}
