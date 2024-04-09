using Gluttonous_Snake.DB;
using Gluttonous_Snake.SceneScripts;
using Gluttonous_Snake.Utils;
using Godot;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluttonous_Snake.SceneModels
{
    public class MainSceneModel : ISceneModel
    {
        private PrintHelper printHelper;

        private FreeSqlHelper freeSqlHelper;

        private SettingHelper settingHelper;
        
        private SettingScene settingScene;

        private GameScene gameScene;

        

        public MainSceneModel(PrintHelper printHelper, FreeSqlHelper freeSqlHelper,SettingHelper settingHelper)
        {
            this.printHelper = printHelper;
            this.freeSqlHelper = freeSqlHelper;
            this.settingHelper = settingHelper;
        }

        public override void Process(double delta)
        {

        }

        public override void Ready()
        {
            printHelper.Info("主函数加载成功！");
            settingScene = Scene.GetNode<SettingScene>("Setting");
            settingScene.Position =new Vector2(settingHelper.WindowWidth/2, settingHelper.WindowHeight/2);
            gameScene = Scene.GetNode<GameScene>("Game");
        }
    }
}
