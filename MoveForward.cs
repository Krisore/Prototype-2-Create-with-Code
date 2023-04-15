
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}
