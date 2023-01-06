using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderJumper : MonoBehaviour
{

    private Animator anim;

    private float jumpForce;

    [SerializeField]
    private float minJumpForce = 5f, maxJumpForce = 10f;

    private Rigidbody2D myBody;

    private float jumpTimer;

    [SerializeField]
    private float minWaitTime = 2f, maxWaitTime = 5f;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        jumpTimer = Time.time + Random.Range(minWaitTime, maxWaitTime);
    }

    private void Update()
    {

        if (Time.time > jumpTimer)
            Jump();

        if(myBody.velocity.y == 0f)
            anim.SetBool(TagManager.JUMP_ANIMATION_PARAM, false);

    }

    void Jump()
    {
        jumpTimer = Time.time + Random.Range(minWaitTime, maxWaitTime);

        jumpForce = Random.Range(minJumpForce, maxJumpForce);

        myBody.velocity = new Vector2(0f, jumpForce);

        anim.SetBool(TagManager.JUMP_ANIMATION_PARAM, true);

    }


} // class


































