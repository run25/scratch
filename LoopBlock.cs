using System;

namespace ScratchFlow.Models
{
    /// <summary>
    /// LOOP
    /// </summary>
    [Serializable]
    public class LoopBlock : Block
    {
        public LoopBlock()
            : base(BlockType.Loop)
        {
            Text = "LOOP";

            LoopType = LoopType.Infinite;
            RepeatCount = 0;
        }

        /// <summary>
        /// ループ種類
        /// </summary>
        public LoopType LoopType { get; set; }

        /// <summary>
        /// Repeat時のみ使用
        /// </summary>
        public int RepeatCount { get; set; }

        /// <summary>
        /// While時のみ使用
        /// </summary>
        public IfBlock WhileCondition { get; set; }
    }
}
