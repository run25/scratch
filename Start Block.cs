using System;

namespace ScratchFlow.Models
{
    /// <summary>
    /// 開始ブロック
    /// </summary>
    [Serializable]
    public class StartBlock : Block
    {
        public StartBlock()
            : base(BlockType.Start)
        {
            Text = "開始";
        }

        public override void Execute(Engine.Context context)
        {
            // 開始ブロックは何もしない
        }
    }
}
