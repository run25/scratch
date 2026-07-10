using ScratchFlow.Models;
using System.Collections.Generic;

namespace ScratchFlow.Engine
{
    public class Executor
    {
        private readonly Context _context;

        public Executor(Context context)
        {
            _context = context;
        }

        public void Execute(List<Block> program)
        {
            foreach (var block in program)
            {
                ExecuteBlock(block);

                if (_context.StopRequested)
                    return;
            }
        }

        private void ExecuteBlock(Block block)
        {
            switch (block.Type)
            {
                case BlockType.Start:
                    ExecuteStart((StartBlock)block);
                    break;

                case BlockType.End:
                    ExecuteEnd((EndBlock)block);
                    break;

                case BlockType.Do:
                    ExecuteDo((DoBlock)block);
                    break;

                case BlockType.If:
                    ExecuteIf((IfBlock)block);
                    break;

                case BlockType.Loop:
                    ExecuteLoop((LoopBlock)block);
                    break;

                case BlockType.Break:
                    ExecuteBreak();
                    break;
            }
        }
