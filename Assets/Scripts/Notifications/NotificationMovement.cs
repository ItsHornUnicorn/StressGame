using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StressGame.Notifications
{
    public class NotificationMovement : MonoBehaviour
    {
        [SerializeField] private float swipeForce = 10f;

        private Vector2 onMouseDownCursorLocation;
        private Vector2 onMouseUpCursorLocation;
        private const int DistanceToSwipeOut = 200;

        private void OnMouseDown()
        {
            onMouseDownCursorLocation = Input.mousePosition;
        }

        private void OnMouseDrag()
        {
            Vector2 mouseLocation = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            transform.position = mouseLocation;
        }

        private void OnMouseUp()
        {
            onMouseUpCursorLocation = Input.mousePosition;

            SwipeOut();
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        private void SwipeOut()
        {
            Vector2 dir = onMouseUpCursorLocation - onMouseDownCursorLocation;
            if (dir.magnitude > Vector2.one.magnitude * DistanceToSwipeOut)
            {
                GetComponent<Rigidbody2D>().AddForce(dir * swipeForce);
            }
        }
        

    }

}