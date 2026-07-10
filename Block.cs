using System;
using System.Collections.Generic;

namespace ScratchFlow.Models
{
    /// <summary>
    /// ブロック基底クラス
    /// </summary>
    [Serializable]
    public abstract class Block
    {
        protected Block(BlockType type)
        {
            Type = type;
            Children = new List<Block>();
        }

        /// <summary>
        /// ブロック種類
        /// </summary>
        public BlockType Type { get; }

        /// <summary>
        /// 表示名
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// IFやLOOPの中に入るブロック
        /// </summary>
        public List<Block> Children { get; }

        /// <summary>
        /// デバッグ表示用
        /// </summary>
        [NonSerialized]
        public bool IsRunning;

        public override string ToString()
        {
            return Text;
        }
    }
}
