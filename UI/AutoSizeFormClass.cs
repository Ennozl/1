using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class AutoSizeFormClass
    {
        // 定义一个控件编号，初始化变量为0，表示窗体本身；后续的为各个控件的编号。
        int CtrNo = 0;
        // 声明一个泛型集合，类型为保存控件属性的结构体
        public List<ControlProperty> OrigenalControl = new List<ControlProperty>();

        // 声明一个结构体，用于保存控件的基本属性
        public struct ControlProperty
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
            public float FontSize;
        }
        //收集控件的属性到集合中
        public void AddControlToList(Control control)
        {
            ControlProperty Ctp = new ControlProperty();    //新建一个控件属性结构体的实例
            foreach (Control c in control.Controls)
            {                   //遍历当前引入的控件集
                Ctp.Left = c.Left;
                Ctp.Top = c.Top;
                Ctp.Width = c.Width;
                Ctp.Height = c.Height;
                Ctp.FontSize = c.Font.Size;
                OrigenalControl.Add(Ctp);
                if (c.Controls.Count > 0)
                {
                    AddControlToList(c);                   //递归函数调用，防止遗漏嵌套的控件（如：Group、Panel等）
                }
            }
        }
        // 窗体自适应分辨率
        public void ControlAutoSize(Control MainForm)
        {

            if (CtrNo == 0)
            {
                ControlProperty Ctp = new ControlProperty();
                Ctp.Left = MainForm.Left;
                Ctp.Top = MainForm.Top;
                Ctp.Height = MainForm.Height;
                Ctp.Width = MainForm.Width;
                Ctp.FontSize = MainForm.Font.Size;
                //先把主窗体的属性加入到集合
                OrigenalControl.Add(Ctp);
                //添加辅窗体控件属性到集合
                AddControlToList(MainForm);
            }
            //求取分辨率的缩放比例
            float WidthScale = (float)MainForm.Width / (float)OrigenalControl[0].Width;
            float HightScale = (float)MainForm.Height / (float)OrigenalControl[0].Height;
            CtrNo = 1; ;//第0个为窗体本身,窗体内的控件,从序号1开始
            AutoScaleControl(MainForm, WidthScale, HightScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
        }

        private void AutoScaleControl(Control mForm, float wScale, float hScale)
        {
            int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
            float ctrFontSize0;
            //第1个是窗体自身的 Left,Top,Width,Height，所以窗体控件从ctrlNo=1开始
            foreach (Control c in mForm.Controls)
            {
                //获得控件原有的位置和大小信息
                ctrLeft0 = OrigenalControl[CtrNo].Left;
                ctrTop0 = OrigenalControl[CtrNo].Top;
                ctrWidth0 = OrigenalControl[CtrNo].Width;
                ctrHeight0 = OrigenalControl[CtrNo].Height;
                ctrFontSize0 = OrigenalControl[CtrNo].FontSize;
                //设置控件新的位置和大小信息。
                c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体
                c.Top = (int)((ctrTop0) * hScale);//
                c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 
                c.Height = (int)(ctrHeight0 * hScale);//
                c.Font = new Font(c.Font.Name, (float)(ctrFontSize0 * wScale));//设置控件中字体的大小以适应控件的大小
                CtrNo++;//累加序号
                //**放在这里，是先缩放控件本身，后缩放控件的子控件，重点是前后要一致（与保存时）
                if (c.Controls.Count > 0)
                    AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
            }
            Debug.Write("如果对象是通过get()方法获取的，而不是new出来的，就可以通过在循环中改变对象的属性的方式来改变集合中该对象的属性值。");
        }


    }
}

