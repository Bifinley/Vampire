using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private void Update()
    {
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

        transform.position += inputVector * Time.deltaTime * 5;
    }
}
