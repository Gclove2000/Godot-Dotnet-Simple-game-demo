using Gluttonous_Snake.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluttonous_Snake.SceneModels
{
    public class GameSceneModel : ISceneModel
    {
        private PrintHelper printHelper;
        public GameSceneModel(PrintHelper printHelper) {
            this.printHelper = printHelper;
            this.printHelper.SetTitle(nameof(GameSceneModel));
        }
        public override void Process(double delta)
        {
        }

        public override void Ready()
        {
            printHelper.Debug("加载完成!");
        }
    }
}
