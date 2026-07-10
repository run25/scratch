using System;

namespace ScratchFlow.Models
{
    /// <summary>
    /// 終了ブロック
    /// </summary>
    [Serializable]
    public class EndBlock : Block
    {
        public EndBlock()
            : base(BlockType.End)
        {
            Text = "終了";
        }

        public override void Execute(Engine.Context context)
        {
            // 終了ブロックは何もしない
        }
    }
}
