using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        if (!gameObject.TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
        {
            return;
        }

        //Déplacement
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * 3 * Time.deltaTime);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 3 * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
        }
    }
}
