using UnityEngine;
using YuCheng.Tool;

namespace YuCheng
{
    /// <summary>
    /// ��������ഫ
    /// </summary>
    public class Class_9_2_DataTypeSwitch:MonoBehaviour
    {
        private void Awake()
        {
            // �����ഫ�G���ݭn�t�~�ŧi�ഫ����
            // �N�p����Ʃ��j����Ƥ�
            byte byte1 = 1;
            int int1 = 0;
            LogSystem.LogWithColor(byte1, "#7f7");
            LogSystem.LogWithColor(byte1.GetType(), "#7f7");
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");
            // �����ഫ�G�N����p�� byte ���j�� int
            int1 = byte1;
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");

            // ����ഫ�G�ݭn�ŧi�ഫ������
            // �N�j����Ʃ��p����Ƥ�
            int int2 = 100;
            byte byte2 = 0;
            LogSystem.LogWithColor(int2, "#7f7");
            LogSystem.LogWithColor(int2.GetType(), "#7f7");
            LogSystem.LogWithColor(byte2, "#7f7");
            LogSystem.LogWithColor(byte2.GetType(), "#7f7");
            // ����ഫ�G�N����j�� int ���p�� byte
            // �K�[(�������)
            byte2 = (byte)int2;
            LogSystem.LogWithColor(byte2, "#7f7");
            LogSystem.LogWithColor(byte2.GetType(), "#7f7");

            // �B�I���ର��ƫ��O�A�p���I�|��
            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogSystem.LogWithColor(byte3, "#f77");

            // �d����j���ର�d����p���A�|�ɭP����
            int int3 = 258;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSystem.LogWithColor(byte4, "#f77");

            LogSystem.LogWithColor("----------", "#ff3");
        }
    }
}
