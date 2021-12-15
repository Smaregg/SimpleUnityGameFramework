using System;
using System.Collections.Generic;
using Utility;

namespace Game
{
    /// <summary>
    /// �ܹ�����
    /// </summary>
    public class GameManager : Singleton<GameManager>
    {
        /// <summary>
        /// ���й�������������ע��
        /// </summary>
        private void RegisterManagers()
        {
            
        }

        /// <summary>
        /// ע�������
        /// </summary>
        /// <typeparam name="T">����������</typeparam>
        private void Register<T>(T instance) where T : class, ManagerInterface, new()
        {
            instance.Init();
            m_lsManagers.Add(instance);
        }

        #region ��������
        public void Init()
        {
            m_lsManagers = new List<ManagerInterface>();
            RegisterManagers();
        }

        public void Update()
        {
            for (int i = 0; i < m_lsManagers.Count; i++)
                m_lsManagers[i].Update();
        }

        public void Dispose()
        {
            for (int i = 0; i < m_lsManagers.Count; i++)
                m_lsManagers[i].Dispose();
            m_lsManagers.Clear();
        }
        #endregion

        /// <summary>
        /// ������ע��Ĺ�����
        /// </summary>
        private List<ManagerInterface> m_lsManagers = null;
    }
}