using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace M.ProductionPipeline
{
    public interface IStep
    {
        /// <summary>
        /// ִ��
        /// </summary>
        void Run();
        /// <summary>
        /// ��ʼִ�д�ӡ
        /// </summary>
        /// <returns></returns>
        string EnterText();
        /// <summary>
        /// ����ִ�д�ӡ
        /// </summary>
        /// <returns></returns>
        string ExitText();
        /// <summary>
        /// �Ƿ�ᴥ������
        /// </summary>
        /// <returns></returns>
        bool IsTriggerCompile();
    }
}