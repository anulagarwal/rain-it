using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovementHandler : MonoBehaviour
{
    #region Properties
    [Header("Properties")]
    [SerializeField] private float moveSpeed = 0f;

    [Header("Components Reference")]
    [SerializeField] private Rigidbody rb = null;

    private Vector3 movementDirection = Vector3.zero;
    private VariableJoystick movementJS = null;
    #endregion

    #region MonoBehaviour Functions
    private void Start()
    {
        movementJS = LevelUIManager.Instance.GetMovementJS;
    }

    private void FixedUpdate()
    {
        CloudNavigation();
    }
    #endregion

    #region Private Core Functions
    private void CloudNavigation()
    {
        movementDirection = new Vector3(movementJS.Horizontal, 0, movementJS.Vertical);

        rb.MovePosition(transform.position + (movementDirection * Time.fixedDeltaTime * moveSpeed));
    }
    #endregion
}
