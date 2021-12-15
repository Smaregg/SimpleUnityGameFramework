using Utility;

namespace Game
{
    /// <summary>
    /// ����Manager�Ļ���
    /// </summary>
    /// <typeparam name="T">Manager��</typeparam>
    public class Manager<T> : Singleton<T>, ManagerInterface where T : class, ManagerInterface, new()
    {
        public virtual void Init() { }

        public virtual void Update() { }

        public virtual void Dispose() { }
    }
}