using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localPosition = new Vector3(0, 0, -3);
        Debug.Log("hi");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
