using UnityEngine;

public class PizzaMoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}
