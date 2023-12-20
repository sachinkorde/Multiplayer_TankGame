using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float movementX;
    [SerializeField] private Vector3 tempScale;
    [SerializeField] private string HORIZONTAL_AXIS = "Horizontal";

    /*void HandleFacingDirection()
    {
        tempScale = transform.localScale;

        if (movementX > 0)
            tempScale.x = Mathf.Abs(tempScale.x);
        else if (movementX < 0)
            tempScale.x = -Mathf.Abs(tempScale.x);

        transform.localScale = tempScale;
    }*/

    void HandlePlayerMovement()
    {
        movementX = Input.GetAxisRaw(HORIZONTAL_AXIS);
        transform.position += moveSpeed * Time.deltaTime * new Vector3(movementX, 0f, 0f);
    }

    void Update()
    {
        HandlePlayerMovement();
        //HandleFacingDirection();
    }
}
