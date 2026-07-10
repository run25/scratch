using System;
using System.Collections.Generic;

namespace ScratchFlow.Models
{
    /// <summary>
    /// 全ブロックの基底クラス
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
        public BlockType Type { get; private set; }

        /// <summary>
        /// 画面表示名
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// 子ブロック
        /// LOOPやIFのみ使用
        /// </summary>
        public List<Block> Children { get; private set; }

        /// <summary>
        /// 親ブロック
        /// </summary>
        [NonSerialized]
        public Block Parent;

        /// <summary>
        /// 実行中表示用
        /// </summary>
        [NonSerialized]
        public bool IsRunning;

        /// <summary>
        /// 実行
        /// </summary>
        public abstract void Execute(Engine.Context context);

        public override string ToString()
        {
            return Text;
        }
    }
}
