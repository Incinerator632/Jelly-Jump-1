using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{

    public float speed = 10.0f;

    private Vector2 touchStart;
    private bool isDragging = false;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    isDragging = true;
                    touchStart = touch.position;
                    break;

                case TouchPhase.Moved:
                    float deltaX = touch.position.x - touchStart.x;
                    if (isDragging)
                    {
                        transform.position += Vector3.right * deltaX * Time.deltaTime * speed;
                    }
                    break;

                case TouchPhase.Ended:
                    isDragging = false;
                    break;
            }
        }
    }
}
