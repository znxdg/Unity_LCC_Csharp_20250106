using UnityEngine;
using YuCheng.Tool;
namespace YuCheng
{
    /// <summary>
    /// �m��9
    /// </summary>
    public class Practices_9_DataTypeSwitch : MonoBehaviour
    {
        private void Awake()
        {
            float float1 = -999.321f;
            sbyte sbyte1;
            sbyte1 = (sbyte) float1;
            LogSystem.LogWithColor(sbyte1, "#7f7");
        }
    }
}
