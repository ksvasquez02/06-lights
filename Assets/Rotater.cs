using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float speed = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = speed * Time.deltaTime;
        transform.transform.Rotate(0, angle, 0, Space.Self);
    }
}
