using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDelegate : MonoBehaviour
{

    [SerializeField]
    private float scaleTime = 1f;

    private Vector3 myScale;

    private bool canScale;

    private BoxCollider2D myCollider;

    private void Awake()
    {
        myCollider = GetComponent<BoxCollider2D>();
    }

    private void OnEnable()
    {
        Key.keyCollectedInfo += UnlockDoor;
    }

    private void OnDisable()
    {
        Key.keyCollectedInfo -= UnlockDoor;
    }

    private void Update()
    {
        Unlock();
    }

    void Unlock()
    {

        if (canScale)
        {

            myScale = transform.localScale;
            myScale.y -= scaleTime * Time.deltaTime;

            if (myScale.y <= 0f)
            {

                myScale.y = 0f;

                myCollider.enabled = false;

                canScale = false;

            }

            transform.localScale = myScale;

        }

    }

    void UnlockDoor()
    {
        canScale = true;
    }


} // class





































