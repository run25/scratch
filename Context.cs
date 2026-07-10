using System;
using System.Collections.Generic;

namespace ScratchFlow.Engine
{
    public class Context
    {
        // DO命令で使用する出力
        public bool Sv1;
        public bool Sv2;

        // センサー値
        public double WaterLevel;

        // AI結果
        public Dictionary<string, bool> AiResults
            = new Dictionary<string, bool>();

        // タイマー開始
        public DateTime StartTime = DateTime.Now;

        // ループ終了要求
        public bool BreakRequested;

        // 停止要求
        public bool StopRequested;
    }
}
