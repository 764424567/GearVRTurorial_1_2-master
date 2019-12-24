using UnityEngine;
using System.Collections;
namespace com.bt.gearVR
{
    public class VRInputTest : MonoBehaviour
    {
        [SerializeField] private VRInput m_VRInput;


        //该脚本激活时，注册对玩家操作的监听
        void OnEnable()
        {
            m_VRInput.OnCancel += OnCalcel;
            m_VRInput.OnClick += OnClick;
            m_VRInput.OnDown += OnDown;
            m_VRInput.OnUp += OnUp;
            m_VRInput.OnDoubleClick += OnDoubleClick;
            m_VRInput.OnSwipe += OnSwip;
        }

        
        void OnSwip(VRInput.SwipeDirection swipeDirection)
        {
            if(swipeDirection!=VRInput.SwipeDirection.NONE)
            {
                Debug.Log("Unity+OnSwipe" + swipeDirection);
            }
           
        }

        //取消对玩家输入的监听
        void OnDisable()
        {
            m_VRInput.OnCancel -= OnCalcel;
            m_VRInput.OnClick -= OnClick;
            m_VRInput.OnDown -= OnDown;
            m_VRInput.OnUp -= OnUp;
            m_VRInput.OnDoubleClick -= OnDoubleClick;
            m_VRInput.OnSwipe -= OnSwip;
        }

        void OnCalcel()
        {
            Debug.Log("Unity+OnCancel");
        }

        void OnClick()
        {
            Debug.Log("Unity+OnClick");
        }
        void OnDown()
        {
            Debug.Log("Unity+OnDown");
        }
        void OnUp()
        {
            Debug.Log("Unity+OnUp");
        }
        void OnDoubleClick()
        {
            Debug.Log("Unity+OnDoubleClick");
        }

        // Use this for initialization
        void Start()
        {

        }
    }
}

