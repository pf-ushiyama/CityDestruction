using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [Header("ステータス")]
    [SerializeField]
    float power;

    [Header("参照したいプレハブ")]
    [SerializeField]
    GameObject shellsPrefab;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            var shellObj = GameObject.Instantiate(shellsPrefab);
            shellObj.transform.SetParent(this.transform);
            shellObj.transform.localPosition = Vector3.zero;
            shellObj.GetComponent<Rigidbody>().AddForce(this.transform.forward * power);
        }
    }
}
