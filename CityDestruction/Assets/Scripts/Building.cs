using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Building : MonoBehaviour
{
    [SerializeField]
    float necessaryPower;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > necessaryPower && transform.childCount > 0)
        {
            while (transform.childCount > 0)
            {
                var child = transform.GetChild(0);

                child.SetParent(this.transform.parent);
                child.gameObject.SetActive(true);
                // child.transform.localScale = new Vector3(   child.transform.localScale.x*this.transform.localScale.x,
                //                                             child.transform.localScale.y*this.transform.localScale.y,
                //                                             child.transform.localScale.z*this.transform.localScale.z);
                // child.transform.localPosition =  new Vector3(   child.transform.localPosition.x*this.transform.localScale.x,
                //                                                 child.transform.localPosition.y*this.transform.localScale.y,
                //                                                 child.transform.localPosition.z*this.transform.localScale.z);

            }

            GameObject.Destroy(this.gameObject);
        }
    }
}
