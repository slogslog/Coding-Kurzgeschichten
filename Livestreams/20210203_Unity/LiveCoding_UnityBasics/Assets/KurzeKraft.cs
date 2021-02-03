using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KurzeKraft : MonoBehaviour
{
    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        // Kraft einwirken lassen.
        // Kraft ist eine physikalische Größe -> Rigidbody des Game Objects das ich bewegen will

        rigid.AddForce(0, 40, 80);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
