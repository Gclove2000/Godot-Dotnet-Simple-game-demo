using Gluttonous_Snake.Utils;
using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gluttonous_Snake.SceneModels
{
    public class SettingSceneModel : ISceneModel
    {
        private PrintHelper printHelper;

        private Button button1;

        private Button button2;

        private Button button3;

        private Button button4;
        public SettingSceneModel(PrintHelper printHelper) {
            this.printHelper = printHelper;
            this.printHelper.SetTitle(nameof(SettingSceneModel));
        }
        public override void Process(double delta)
        {
            //throw new NotImplementedException();
        }

        public override void Ready()
        {
            printHelper.Debug("加载完成!");

            button1 = Scene.GetNode<Button>("VBoxContainer/Button1");
            button2 = Scene.GetNode<Button>("VBoxContainer/Button2");
            button3 = Scene.GetNode<Button>("VBoxContainer/Button3");
            button4 = Scene.GetNode<Button>("VBoxContainer/Button4");


            button1.ButtonDown += Button1_ButtonDown;
            button2.ButtonDown += Button2_ButtonDown;
            button3.ButtonDown += Button3_ButtonDown;
            button4.ButtonDown += Button4_ButtonDown;
            //throw new NotImplementedException();
        }

        private void Button1_ButtonDown()
        {
            printHelper.Debug("Button1");
        }
        private void Button2_ButtonDown()
        {
            printHelper.Debug("Button2");
        }
        private void Button3_ButtonDown()
        {
            printHelper.Debug("Button3");
        }
        private void Button4_ButtonDown()
        {
            printHelper.Debug("Button4");
        }
    }
}
