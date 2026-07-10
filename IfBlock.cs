using System;

namespace ScratchFlow.Models
{
    /// <summary>
    /// IFブロック
    /// </summary>
    [Serializable]
    public class IfBlock : Block
    {
        public IfBlock()
            : base(BlockType.If)
        {
            Text = "IF";
        }

        /// <summary>
        /// 条件種類
        /// </summary>
        public ConditionType ConditionType { get; set; }

        /// <summary>
        /// 条件名
        /// 例)
        /// WaterLevel
        /// Person
        /// Timer
        /// </summary>
        public string ConditionName { get; set; }

        /// <summary>
        /// 比較方法
        /// </summary>
        public CompareType Compare { get; set; }

        /// <summary>
        /// 比較値
        /// </summary>
        public string Value { get; set; }
    }
}
