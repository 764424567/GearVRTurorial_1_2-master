using UnityEngine;
using System.Collections;
namespace com.bt.gearVR
{
    public class GearVRPlayerControl : MonoBehaviour
    {

        public VRInput m_VRInput;
        public float m_Speed;
        public float m_Dampening;
        public Transform m_Head;
        public bool useGravity = false;

        private bool isMoving = false;
        private Vector3 targetPosition;



        private void OnEnable()
        {
            m_VRInput.OnDown += OnDown;
            m_VRInput.OnUp += OnUp;
        }
        private void OnDisable()
        {
            m_VRInput.OnDown -= OnDown;
            m_VRInput.OnUp -= OnUp;
        }
        void OnDown()
        {
            isMoving = true;
        }
        void OnUp()
        {
            isMoving = false;
        }

        // Use this for initialization
        void Start()
        {
            //targetPosition = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (isMoving)
            {
                Vector3 dir = m_Head.forward;
                if (useGravity)
                {
                    dir.y = 0;
                }
                transform.position += dir * m_Speed * Time.deltaTime;
                //transform.position = targetPosition;
            }
            // SgtHelper.Dampen3(transform.position, targetPosition, m_Dampening, Time.deltaTime, 0.1f);
        }
    }
}

