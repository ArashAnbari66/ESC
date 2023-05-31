using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ResetRigidbodys : MonoBehaviour
{
    [SerializeField]
    Rigidbody[] m_Rigidbodies;

    private Vector3[] _startPositions;
    private Quaternion[] _startRotations;

    private void Awake()
    {
        _startPositions = new Vector3[m_Rigidbodies.Length];
        _startRotations = new Quaternion[m_Rigidbodies.Length];

        var i = 0;
        
        foreach (var b in m_Rigidbodies) 
        {
            var transformRef = b.transform;
            _startPositions[i] = transformRef.position;
            _startRotations[i] = transformRef.rotation;
            i++;
        }
    }

    [ContextMenu("Reset")]
    public void ResetPose()
    {
        var i = 0;
        foreach(var b in m_Rigidbodies)
        {
            b.MovePosition(_startPositions[i]);
            b.MoveRotation(_startRotations[i]);

            b.angularVelocity = Vector3.zero;
            b.velocity= Vector3.zero;

            i++;
        }
    }
}
