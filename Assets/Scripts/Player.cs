using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Animator anim;
    float hor, ver;
    float moveSpeed = 10;
    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }
    void Update () {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if (Mathf.Abs(hor) > 0.1 || Mathf.Abs(ver) > 0.1)
        {
            float newSpeed=Mathf.Lerp(anim.GetFloat("Speed"), 5.6f, moveSpeed * Time.deltaTime);
            anim.SetFloat("Speed", newSpeed);
            Vector3 targetDir = new Vector3(hor, 0, ver);
            Quaternion newRotation = Quaternion.LookRotation(targetDir, Vector3.up);
            transform.rotation= Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * 10);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation, 1);
            anim.SetFloat("Speed",0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Snake", true);
        }
        else
        {
            anim.SetBool("Snake",false);
        }
    }
}
