using System;

namespace ScratchFlow.Models
{
    /// <summary>
    /// ブロック種類
    /// </summary>
    public enum BlockType
    {
        Start,     // 開始
        End,       // 終了

        Do,        // 動作

        If,        // 条件分岐

        Loop,      // ループ開始

        Break      // ループ終了(BREAK)
    }
}
