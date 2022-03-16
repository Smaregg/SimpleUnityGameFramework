using UnityEngine.SceneManagement;

namespace Framework.Scene
{
    public class SceneManager : Manager<SceneManager>
    {
        /// <summary>
        /// ��ǰ�����صĳ�����
        /// </summary>
        public string LoadingScene { get; private set; }

        /// <summary>
        /// ����ģʽ
        /// Single��Addictive
        /// </summary>
        public LoadSceneMode LoadMode { get; private set; }

        /// <summary>
        /// �л�����
        /// </summary>
        /// <param name="sceneName">������</param>
        /// <param name="loadMode">����ģʽ</param>
        /// <param name="isAsync">�Ƿ��첽����</param>
        public void SwitchScene(string sceneName, LoadSceneMode loadMode = LoadSceneMode.Additive, bool isAsync = false)
        {
            LoadingScene = sceneName;
            LoadMode = loadMode;
            if (isAsync)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("Scene_Load", LoadSceneMode.Additive);
            }
            else
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName, loadMode);
            }
        }

        #region ��������
        public override void Init()
        {
            base.Init();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
        #endregion
    }
}