using UnityEngine;

public class cameraFllow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    public float smothSpeed = 0.4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newposition = Vector3.Lerp(transform.position, target.position + offset, smothSpeed);
        transform.position = newposition;
    }
}
