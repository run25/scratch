using System;

namespace ScratchFlow.Models
{
    public enum DoAction
    {
        Sv1On,
        Sv1Off,

        Sv2On,
        Sv2Off,

        AiStart,
        AiStop,

        Wait,

        Custom
    }

    [Serializable]
    public class DoBlock : Block
    {
        public DoBlock()
            : base(BlockType.Do)
        {
            Text = "DO";
        }

        /// <summary>
        /// 実行する命令
        /// </summary>
        public DoAction Action { get; set; }

        /// <summary>
        /// パラメータ
        /// 例
        /// Waitなら5000(ms)
        /// AI番号
        /// 出力番号など
        /// </summary>
        public string Parameter { get; set; }
    }
}
