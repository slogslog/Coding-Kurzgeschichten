using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DauerKraft : MonoBehaviour
{
    public Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    // Alle Physikaktionen werden nicht in Update() sondern FixedUpdate()
    void FixedUpdate()
    {
        rigid.AddForce(0, 0, 300 * Time.deltaTime);
    }
}
