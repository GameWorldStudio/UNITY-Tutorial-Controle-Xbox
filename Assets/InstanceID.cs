using UnityEngine;

public class InstanceID : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name + " : " + gameObject.GetInstanceID());
    }
}
