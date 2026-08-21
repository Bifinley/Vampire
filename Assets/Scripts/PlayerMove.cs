using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5;

    private void Update()
    {

        // Basic AHH movement

        Vector3 inputVector = new Vector3(0,0);

        if (Input.GetKey(KeyCode.W)){
            inputVector.z += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.z -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1;
        }

        transform.position += inputVector * Time.deltaTime * walkSpeed;
    }
}
