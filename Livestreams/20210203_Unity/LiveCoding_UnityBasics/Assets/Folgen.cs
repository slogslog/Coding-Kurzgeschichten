using UnityEngine;

public class Folgen : MonoBehaviour
{
    public Transform kugel;
    public Vector3 abstand;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = kugel.position + abstand;
    }
}
