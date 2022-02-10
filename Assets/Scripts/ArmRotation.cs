using UnityEngine;
using UnityEngine.InputSystem;

public class ArmRotation : MonoBehaviour
{

    [SerializeField] private PlayerController playerController;
    [SerializeField] private Camera mainCamera;

    private void Start()
    {
        playerController.GetComponent<PlayerInput>().actions.FindAction("Look").performed += HandleLook;
    }

    private void HandleLook(InputAction.CallbackContext ctx)
    {
        var mousePosition = ctx.ReadValue<Vector2>();
        var position = mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y));

        Vector2 vector = (position - transform.position).normalized;
        transform.up = vector;

        //transform.rotation = new Quaternion(0f, 0f, 0f, 1f);
    }
}