using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMoveController : MonoBehaviour
{

    // PUBLIC
    public SimpleTouchController leftController;
    public SimpleTouchController rightController;
    public Transform headTrans;
    public float speedMovements = 5f;
    public float speedContinuousLook = 100f;
    public float speedProgressiveLook = 300f;

    // PRIVATE
    private Rigidbody _rigidbody;
    [SerializeField] bool continuousRightController = true;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public bool ContinuousRightController
    {
        set { continuousRightController = value; }
    }

//    void Update()
//    {
//        // move
//        _rigidbody.MovePosition(transform.position + (transform.forward * leftController.GetTouchPosition.y * Time.deltaTime * speedMovements));// +
//
//        var rot = Quaternion.Euler(0,
//            transform.localEulerAngles.y + leftController.GetTouchPosition.x * Time.deltaTime * speedProgressiveLook,
//            0f);
//
//        _rigidbody.MoveRotation(rot);
//                                                                                                                                                //            (transform.right * leftController.GetTouchPosition.x * Time.deltaTime * speedMovements));
//    }
}
