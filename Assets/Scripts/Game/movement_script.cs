using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_script : MonoBehaviour
{
    float speed = 0.2f;

    void FixedUpdate()
    {
        checkInputs();
    }

    IEnumerator MoveDir(float x, float z)
    {
        x *= speed;
        z *= speed;

        transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);
        yield return new WaitForSecondsRealtime(0.01f);
    }


    void checkInputs()
    {
        int hor = (int)Input.GetAxisRaw("Horizontal");
        int ver = (int)Input.GetAxisRaw("Vertical");

        if (hor != 0)
        {
            StartCoroutine(MoveDir(hor, 0));
        }

        else if (ver != 0)
        {
            StartCoroutine(MoveDir(0, ver));
        }
    }
}
