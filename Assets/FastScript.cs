using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FastScript : MonoBehaviour
{
    [SerializeField]private Transform d;
    void Update()
    {
        Debug.Log("a1 " + Vector3.Angle(transform.forward, Vector3.up));
        Debug.Log("d2 " + Vector3.Angle(Vector3.up, d.position - transform.position));
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position+(transform.forward*1));
        Gizmos.DrawLine(transform.position, transform.position+Vector3.up);  
        Gizmos.DrawLine(transform.position, d.position);  
    }
}
