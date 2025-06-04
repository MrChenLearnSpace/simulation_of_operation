using UnityEngine;

public class move : MonoBehaviour
{
    public Transform go;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(go == null) {
           go = this.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(go) {
            go.position += new Vector3(-0.01f, 0, 0);
        }
    }
}
