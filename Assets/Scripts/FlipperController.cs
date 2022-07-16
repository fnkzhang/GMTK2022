using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    [SerializeField] private Transform _leftFlipper;
    [SerializeField] private Transform _rightFlipper;
    [SerializeField] private HingeJoint _leftJoint;
    [SerializeField] private HingeJoint _rightJoint;
    private JointSpring leftSpring;
    private JointSpring rightSpring;
    public float springAmt;

    // Start is called before the first frame update
    void Start()
    {
        leftSpring = new JointSpring();
        rightSpring = new JointSpring();
        leftSpring.spring = springAmt;
        leftSpring.damper = 150f;
        rightSpring.spring = springAmt;
        rightSpring.damper = 150f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftSpring.targetPosition = -60;
            //_leftFlipper.localEulerAngles += new Vector3(0, 0, 2f);
        }
        else
        {
            leftSpring.targetPosition = 0;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightSpring.targetPosition = 60;
            //_leftFlipper.localEulerAngles += new Vector3(0, 0, 2f);
        }
        else
        {
            rightSpring.targetPosition = 0;
        }
        _leftJoint.spring = leftSpring;
        _rightJoint.spring = rightSpring;
    }
}