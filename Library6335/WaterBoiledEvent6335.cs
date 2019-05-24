using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library6335 {
    /// <summary>
    /// 事件接收者：报警器
    /// </summary>
    public static class Alarm6335 {
        public static void MakeAlert6335(object sender, WaterBoiledEventArgs e) {
            System.Media.SystemSounds.Asterisk.Play();
        }
    }

    /// <summary>
    /// 事件参数类：封装事件发生时的水温
    /// </summary>
    public class WaterBoiledEventArgs : EventArgs {
        public WaterBoiledEventArgs(int temperature) {
            Temperature = temperature;
        }

        public int Temperature { get; set; }
    }

    /// <summary>
    /// 事件源:热水器类
    /// </summary>
    public class Heater6335 {
        public event EventHandler<WaterBoiledEventArgs> WaterBoiled;

        /// <summary>
        /// 热水器加热方法
        /// 感知温度的变化，当温度超过96度时，
        /// 封装要传递的数据（当前温度），调用通知方法
        /// </summary>
        public void Heating() {
            for (int i = 0; i <= 100; i++) {
                int temperature = i;
                if (temperature > 96) {
                    if (WaterBoiled != null) {
                        OnWaterBoiled(new WaterBoiledEventArgs(temperature));
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }

        /// <summary>
        /// 事件发生时通知订阅者
        /// </summary>
        /// <param name="args">事件参数对象</param>
        private void OnWaterBoiled(WaterBoiledEventArgs args) {
            WaterBoiled?.Invoke(this, args);
        }
    }

    /// <summary>
    /// 事件接收者：水温显示
    /// </summary>
    public class Display6335 {
        /// <summary>
        /// Initializes a new instance of the <see cref="Display6335"/> class.
        /// 初始化属性
        /// </summary>
        /// <param name="screen">listbox对象</param>
        public Display6335(ListBox screen) {
            Screen = screen;
        }

        public ListBox Screen { get; set; }

        public void ShowMsg(object sender, WaterBoiledEventArgs e) {
            Screen.Items.Add($"水快烧开了，当前温度：{e.Temperature }度。");
            Screen.Refresh();
        }
    }

}
