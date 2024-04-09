using Gluttonous_Snake.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluttonous_Snake.SceneModels
{
    public class MessageSceneModel:ISceneModel
    {
        private PrintHelper printHelper;

        public MessageSceneModel(PrintHelper printHelper) {
            this.printHelper = printHelper;
            this.printHelper.SetTitle(nameof(MessageSceneModel));
        }

        public override void Process(double delta)
        {
            //throw new NotImplementedException();
        }

        public override void Ready()
        {
            printHelper.Debug("加载完成!");
            //throw new NotImplementedException();
        }
    }
}
