using UnityEngine;

namespace Game
{
    /// <summary>
    /// ��Ϸ���
    /// </summary>
    public class GameMain : MonoBehaviour
    {
        #region ��������
        void Start()
        {
            GameManager.Instance.Init();
        }

        void Update()
        {
            GameManager.Instance.Update();
        }
        #endregion
    }
}