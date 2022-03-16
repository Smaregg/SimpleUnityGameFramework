using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Framework.UI
{
    public class LoadWindow : MonoBehaviour
    {
        /// <summary>
        /// �첽����Э��
        /// </summary>
        private IEnumerator LoadScene()
        {
            m_optLoad = SceneManager.LoadSceneAsync(m_strAsyncLoadScene, m_modLoad);
            m_optLoad.completed += OnLoadComplete;
            if (m_optLoad.progress == 1)
                yield break;
            yield return 0;
        }

        /// <summary>
        /// ����������ɻص�
        /// </summary>
        private void OnLoadComplete(AsyncOperation opt)
        {
            SceneManager.UnloadSceneAsync("Scene_Load");
        }

        // Start is called before the first frame update
        void Start()
        {
            m_strAsyncLoadScene = Scene.SceneManager.Instance.LoadingScene;
            m_modLoad = Scene.SceneManager.Instance.LoadMode;
            StartCoroutine("LoadScene");
        }

        #region ˽�г�Ա
        /// <summary>
        /// �첽���ؾ��
        /// </summary>
        private AsyncOperation m_optLoad = null;

        /// <summary>
        /// ���س�������
        /// </summary>
        private string m_strAsyncLoadScene = string.Empty;

        /// <summary>
        /// ���س���ģʽ
        /// </summary>
        private LoadSceneMode m_modLoad = LoadSceneMode.Single;
        #endregion
    }
}